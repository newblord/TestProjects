using System.Globalization;
using DatabaseGenerationToolExt.DatabaseObjects;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DatabaseGenerationToolExt.Helpers;
using EnvDTE;

namespace DatabaseGenerationToolExt.DesignPatterns
{
    public abstract class DesignPattern
    {

        public DesignPattern(string targetFrameworkVersion, DatabaseGenerationSetting setting, Microsoft.VisualStudio.Shell.Package package)
        {
            TargetFrameworkVersion = targetFrameworkVersion;
            Setting = setting;
            GenerationEnvironment = new StringBuilder();
            NewFiles = new List<NewFile>();
            dte = VisualStudioHelper.GetDTE();

            CheckOutAction = fileName => dte.SourceControl.CheckOutItem(fileName);
            SyncProjectsAction = keepFileNames => SyncProjects(keepFileNames);
        }

        #region Private Properties

        private Action<string> CheckOutAction;
        private Action<IEnumerable<NewFile>> SyncProjectsAction;
        private DTE dte;

        #endregion

        #region Public Properties

        public DatabaseGenerationSetting Setting { get; set; }

        /// <summary>
        /// If set to false, existing files are not overwritten
        /// </summary>
        /// <returns></returns>
        public bool CanOverrideExistingFile { get; set; }

        /// <summary>
        /// Defines Encoding format for generated output file. (Default UTF8)
        /// </summary>
        /// <returns></returns>
        public System.Text.Encoding Encoding { get; set; }

        /// <summary>
        /// To include extra namespaces, include them here. i.e. "Microsoft.AspNet.Identity.EntityFramework"
        /// </summary>
        public virtual string[] AdditionalNamespaces { get; set; } = new[] { "" };

        /// <summary>
        /// To include extra db context interface items, include them here. Also set MakeClassesPartial=true, and implement the partial DbContext class functions.
        /// </summary>
        public virtual string[] AdditionalContextInterfaceItems { get; set; } = new[]
        {
            ""  //  example: "void SetAutoDetectChangesEnabled(bool flag);"
	    };

        /// <summary>
        /// If you need to serialize your entities with the JsonSerializer from Newtonsoft, this would serialize
        /// all properties including the Reverse Navigation and Foreign Keys. The simplest way to exclude them is
        /// to use the data annotation [JsonIgnore] on reverse navigation and foreign keys.
        /// </summary>
        public virtual string[] AdditionalReverseNavigationsDataAnnotations { get; set; } = new string[]
        {
            // "JsonIgnore"
        };

        public virtual string[] AdditionalForeignKeysDataAnnotations { get; set; } = new string[]
        {
            // "JsonIgnore"
        };

        #endregion

        private static string TargetFrameworkVersion;

        public bool IsSupportedFrameworkVersion(string frameworkVersion)
        {
            if (!string.IsNullOrEmpty(TargetFrameworkVersion))
            {
                var nfi = CultureInfo.InvariantCulture.NumberFormat;
                float target = float.Parse(TargetFrameworkVersion, nfi);
                float isSupported = float.Parse(frameworkVersion, nfi);
                return isSupported <= target;
            }
            return true;
        }

        public virtual string WritePocoClassAttributes(Table t)
        {
            // Do nothing by default
            // Example:
            // if(t.ClassName.StartsWith("Order"))
            //	  WriteLine("	 [SomeAttribute]");

            if (Setting.UseDataAnnotations)
            {
                return $"[Table(\"{t.Name}\", Schema = \"{t.Schema}\")]";
            }

            return string.Empty;
        }

        public virtual string WritePocoBaseClasses(Table t)
        {
            //if (t.ClassName == "User")
            //	 return "IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>, ";
            return "";
        }

        public virtual string WritePocoBaseClassBody(Table t)
        {
            // Do nothing by default
            // Example:
            // WriteLine("		  // " + t.ClassName);

            return string.Empty;
        }

        public virtual string WritePocoColumn(Column c)
        {
            // Example of adding a [Required] data annotation attribute to all non-null fields
            //if (!c.IsNullable)
            //	 return "[System.ComponentModel.DataAnnotations.Required] " + c.Entity;

            StringBuilder sb = new StringBuilder();

            if (Setting.UseDataAnnotations)
            {
                if (c.IsIdentity)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
                if (c.IsComputed)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
                if (c.IsPrimaryKey && !c.IsIdentity && !c.IsStoreGenerated)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.None)]");

                if (c.IsPrimaryKey)
                    sb.AppendLine("[Key]");
                if (!c.IsNullable)
                    sb.AppendLine("[Required]");
                if (!c.IsMaxLength && c.MaxLength > 0)
                {
                    sb.AppendLine(string.Format("[MaxLength({0})]", c.MaxLength));
                    if (c.PropertyType.Equals("string", StringComparison.InvariantCultureIgnoreCase))
                        sb.AppendLine(string.Format("[StringLength({0})]", c.MaxLength));
                }
                if (c.IsMaxLength)
                    sb.AppendLine("[MaxLength]");

                sb.AppendLine(string.Format("[Column(\"{0}\", TypeName=\"{1}\")]"
                                , c.Name
                                , c.SqlPropertyType
                            //,c.IsPrimaryKey ? string.Format(", Order = {0}", c.PrimaryKeyOrdinal) : ""
                            ));
            }

            sb.AppendLine(c.Entity);

            return sb.ToString();
        }

        public virtual string WritePocoInterfaceColumn(Column c)
        {
            // Example of adding a [Required] data annotation attribute to all non-null fields
            //if (!c.IsNullable)
            //	 return "[System.ComponentModel.DataAnnotations.Required] " + c.Entity;

            return c.InterfaceEntity;
        }

        #region File Generation Methods

        private NewFile currentFile;
        private List<string> Indents { get; set; }
        private string TotalIndentValue { get; set; }
        private List<NewFile> NewFiles { get; set; }
        private StringBuilder GenerationEnvironment { get; set; }
        private NewFile CurrentFile
        {
            get { return currentFile; }
            set
            {
                if (CurrentFile != null)
                {
                    EndFile();
                }

                if (value != null)
                {
                    value.Start = GenerationEnvironment.Length;
                }

                currentFile = value;
            }
        }

        public virtual void EndFile()
        {
            if (CurrentFile == null)
            {
                return;
            }

            CurrentFile.Length = GenerationEnvironment.Length - currentFile.Start;
            NewFiles.Add(CurrentFile);

            currentFile = null;
        }

        public void StartNewFile(string fileName, string projectName, string folderName)
        {
            Indents = new List<string>();
            CurrentFile = new NewFile();

            CurrentFile.FileName = fileName;
            CurrentFile.ProjectName = projectName;
            CurrentFile.FolderName = folderName;
        }

        public void ProcessFiles()
        {
            var list = new List<NewFile>();

            if (NewFiles.Any())
            {
                // check selectitem first
                string defaultPath = string.Empty;
                string currentProjectName = string.Empty;
                var selectedItems = dte.SelectedItems.Cast<SelectedItem>();
                if (selectedItems.Count() == 1)
                {
                    SelectedItem item = selectedItems.FirstOrDefault();

                    if (item.Project != null)
                    {
                        Project p = VisualStudioHelper.FindProject(item.Project.Name);
                        currentProjectName = item.Project.Name;
                        defaultPath = VisualStudioHelper.GetProjectPath(item.Project);
                    }
                    else if (item.ProjectItem != null)
                    {
                        defaultPath = item.ProjectItem.FileNames[0];
                    }
                }

                NewFiles.Reverse();

                var groupedFiles = (from f in NewFiles
                                    group f by new { f.ProjectName, f.FolderName }
                                      into l
                                    select new
                                    {
                                        ProjectName = l.Key.ProjectName,
                                        FolderName = l.Key.FolderName,
                                        OutputFiles = l.ToArray()
                                    }).ToArray();

                for (int x = 0; x < groupedFiles.Length; x++)
                {
                    var outputPath = VSHelper.GetOutputPath(dte, NewFiles[x].ProjectName, NewFiles[x].FolderName, defaultPath);
                    var outputFiles = groupedFiles[x].OutputFiles;

                    for (int i = 0; i < outputFiles.Length; i++)
                    {
                        var outputFile = NewFiles[i];

                        if(outputFile.ProjectName == null)
                        {
                            outputFile.ProjectName = currentProjectName;
                        }

                        outputFile.FilePath = Path.Combine(outputPath, outputFile.FileName);
                        outputFile.FileContent = GenerationEnvironment.ToString(outputFile.Start, outputFile.Length);
                        outputFile.OutputPath = outputPath;

                        CreateFile(outputFile);
                        GenerationEnvironment.Remove(outputFile.Start, outputFile.Length);

                        list.Add(outputFile);
                    }
                }
            }

            if (list.Count > 0)
            {
                SyncProjectsAction.EndInvoke(SyncProjectsAction.BeginInvoke(list, null, null));

                this.WriteLog(list);
            }
        }

        private void CreateFile(NewFile file)
        {
            if (IsFileContentDifferent(file))
            {
                File.WriteAllText(file.FilePath, file.FileContent);
            }
        }

        private bool IsFileContentDifferent(NewFile file)
        {
            return !(File.Exists(file.FileName) && File.ReadAllText(file.FileName) == file.FileContent);
        }

        private void WriteLog(List<NewFile> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                Logger.AddLog($"// {list[i].FileName}");
            }
        }

        private void SyncProjects(IEnumerable<NewFile> keepFileNames)
        {
            var groupedFileNames = from f in keepFileNames
                                   group f by new { f.ProjectName, f.FolderName }
                                    into l
                                   select new
                                   {
                                       ProjectName = l.Key.ProjectName,
                                       FolderName = l.Key.FolderName,
                                       FirstItem = l.First(),
                                       OutputFiles = l
                                   };

            foreach (var item in groupedFileNames)
            {
                ProjectItem pi = VisualStudioHelper.FindProjectItem(item.ProjectName, item.FolderName);
                Project prj = VisualStudioHelper.FindProject(item.ProjectName);

                if (pi != null)
                {
                    prj.ProjectItems.AddFromDirectory(Path.GetDirectoryName(pi.FileNames[0]));

                    if (!prj.Saved)
                    {
                        prj.Save();
                    }
                }
                else
                {
                    SyncProjectFiles(prj, item.OutputFiles);
                }
            }

            // TODO: Check this code and do some testing on it
            // clean up
            //bool hasDefaultItems = groupedFileNames.Where(f => String.IsNullOrEmpty(f.ProjectName) && String.IsNullOrEmpty(f.FolderName)).Count() > 0;
            //if (hasDefaultItems == false)
            //{
            //    ProjectItemSyncPart(templateProjectItem, new List<OutputFile>());
            //}
        }

        private static void SyncProjectFiles(Project project, IEnumerable<NewFile> keepFileNames)
        {
            var keepFileNameSet = new HashSet<NewFile>(keepFileNames);

            var projectFiles = new Dictionary<string, ProjectItem>();
            //var originalOutput = Path.GetFileNameWithoutExtension(project.FileName);

            foreach (ProjectItem projectItem in project.ProjectItems)
            {
                projectFiles.Add(projectItem.FileNames[0], projectItem);
            }

            //// Remove unused items from the project
            //foreach (var pair in projectFiles)
            //{
            //	bool isNotFound = keepFileNames.Where(f => f.FileName == pair.Key).Count() == 0;
            //	if (isNotFound == true
            //		&& !(Path.GetFileNameWithoutExtension(pair.Key) + ".").StartsWith(originalOutput + "."))
            //	{
            //		pair.Value.Delete();
            //	}
            //}

            // Add missing files to the project
            foreach (var fileName in keepFileNameSet)
            {
                if (!projectFiles.ContainsKey(fileName.FileName))
                {
                    project.ProjectItems.AddFromFile(fileName.FilePath);
                }
            }
        }

        private static void ProjectItemSyncPart(ProjectItem templateProjectItem, IEnumerable<OutputFile> keepFileNames)
        {
            var keepFileNameSet = new HashSet<OutputFile>(keepFileNames);
            var projectFiles = new Dictionary<string, ProjectItem>();
            var originalOutput = Path.GetFileNameWithoutExtension(templateProjectItem.FileNames[0]);

            foreach (ProjectItem projectItem in templateProjectItem.ProjectItems)
            {
                projectFiles.Add(projectItem.FileNames[0], projectItem);
            }

            // Remove unused items from the project
            foreach (var pair in projectFiles)
            {
                bool isNotFound = keepFileNames.Where(f => f.FileName == pair.Key).Count() == 0;
                if (isNotFound == true
                    && !(Path.GetFileNameWithoutExtension(pair.Key) + ".").StartsWith(originalOutput + "."))
                {
                    pair.Value.Delete();
                }
            }

            // Add missing files to the project
            foreach (var fileName in keepFileNameSet)
            {
                if (!projectFiles.ContainsKey(fileName.FileName))
                {
                    templateProjectItem.ProjectItems.AddFromFile(fileName.FileName);
                }
            }
        }

        private void CheckoutFileIfRequired(string fileName)
        {
            if (dte.SourceControl == null || !dte.SourceControl.IsItemUnderSCC(fileName) || dte.SourceControl.IsItemCheckedOut(fileName))
            {
                return;
            }

            // run on worker thread to prevent T4 calling back into VS
            CheckOutAction.EndInvoke(CheckOutAction.BeginInvoke(fileName, null, null));
        }

        public virtual void WriteLine(string line)
        {
            WriteLine("{0}{1}", TotalIndentValue, line);
        }

        public virtual void WriteLine(string line, params object[] args)
        {
            GenerationEnvironment.AppendFormat($"{TotalIndentValue}{line}", args);
            GenerationEnvironment.AppendLine();
        }

        public virtual void PushIndent(string indent)
        {
            Indents.Add(indent);
            TotalIndentValue = $"{TotalIndentValue}{indent}";
        }

        public virtual void PopIndent()
        {
            if (Indents.Count > 0)
            {
                Indents.RemoveAt(Indents.Count - 1);
                TotalIndentValue = string.Join("", Indents);
            }
        }

        public virtual void CreateHeader()
        {
            WriteLine("//------------------------------------------------------------------------------");
            WriteLine("// <auto-generated>");
            WriteLine("//	  This code was generated from a template.");
            WriteLine("//");
            WriteLine("//	  Manual changes to this file may cause unexpected behavior in your application.");
            WriteLine("//	  Manual changes to this file will be overwritten if the code is regenerated.");
            WriteLine("// </auto-generated>");
            WriteLine("//------------------------------------------------------------------------------");
            WriteLine("");
        }

        public virtual void BeginNamespace(string name)
        {
            WriteLine("namespace {0}", name);
            WriteLine("{");
            PushIndent("\t");
        }

        public virtual void BeginInterface(string name, bool isPartial, string baseClass)
        {
            WriteLine("public {0}interface {1}{2}", isPartial ? "partial " : "", name, !string.IsNullOrEmpty(baseClass) ? " : " + baseClass : "");
            WriteLine("{");
            PushIndent("\t");
        }

        public virtual void BeginClass(string name, bool isPartial, string baseClass)
        {
            WriteLine("public {0}class {1}{2}", isPartial ? "partial " : "", name, !string.IsNullOrEmpty(baseClass) ? " : " + baseClass : "");
            WriteLine("{");
            PushIndent("\t");
        }

        public virtual void CloseBrace()
        {
            PopIndent();
            WriteLine("}");
        }

        public virtual void OpenMethodBrace()
        {
            WriteLine("{");
            PushIndent("\t");
        }

        public virtual void CloseMethodBrace()
        {
            PopIndent();
            WriteLine("}");
            WriteLine("");
        }

        #endregion
    }
}
