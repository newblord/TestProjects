using System.Globalization;
using DatabaseGenerationToolExt.DatabaseObjects;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DatabaseGenerationToolExt.Helpers;
using EnvDTE;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace DatabaseGenerationToolExt.DesignPatterns
{
	public abstract class DesignPattern
	{

		public DesignPattern(string targetFrameworkVersion, DatabaseGenerationSetting setting, Microsoft.VisualStudio.Shell.Package package, Tables tables, List<StoredProcedure> storedProcs)
		{
			TargetFrameworkVersion = targetFrameworkVersion;
			Setting = setting;
            Tables = tables;
			StoredProcedures = storedProcs;
			GenerationEnvironment = new StringBuilder();
			NewFiles = new List<NewFile>();
			dte = VisualStudioHelper.GetDTE();
			Stopwatch = new System.Diagnostics.Stopwatch();
			Stopwatch.Start();

			CheckOutAction = fileName => dte.SourceControl.CheckOutItem(fileName);
			SyncProjectsAction = keepFileNames => SyncProjects(keepFileNames);
		}

		#region Private Properties

		private Action<string> CheckOutAction;
		private Action<IEnumerable<NewFile>> SyncProjectsAction;
		private DTE dte;

		#endregion

		#region Public Properties

		public string ConfigurationFolderName { get; set; } = "Configurations";
		public string ConfigurationProjectName { get; set; }
		public string ContextFolderName { get; set; } = "Context";
		public string ContextProjectName { get; set; }
		public string ModelFolderName { get; set; } = "Models";
		public string ModelProjectName { get; set; }
		public string ModelInterfaceFolderName { get; set; } = "ModelInterfaces";
		public string ModelInterfaceProjectName { get; set; }
		public string RepositoryFolderName { get; set; } = "Repositories";
		public string RepositoryProjectName { get; set; }
		public string RepositoryInterfaceFolderName { get; set; } = "RepositoryInterfaces";
		public string RepositoryInterfaceProjectName { get; set; }
		public string ServiceFolderName { get; set; } = "Services";
		public string ServiceProjectName { get; set; }
		public string ServiceInterfaceFolderName { get; set; } = "ServiceInterfaces";
		public string ServiceInterfaceProjectName { get; set; }

		public string ContextNamespace { get; set; } = "Context";
		public string PocoInterfaceNamespace { get; set; } = "Poco.Interface";
		public string PocoNamespace { get; set; } = "Poco";
		public string PocoConfigurationNamespace { get; set; } = "Poco.Configuration";
		public string RepositoryInterfaceNamespace { get; set; } = "Repository.Interface";
		public string RepositoryNamespace { get; set; } = "Repository";
		public string ServiceInterfaceNamespace { get; set; } = "Service.Interface";
		public string ServiceNamespace { get; set; } = "Service";
		public string UnitOfWorkNamespace { get; set; } = "Context.UnitOfWork";

		public DatabaseGenerationSetting Setting { get; set; }

		public Tables Tables { get; set; }

		public List<StoredProcedure> StoredProcedures { get; set; }

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

		private System.Diagnostics.Stopwatch Stopwatch;
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

        public static void ProcessDatabaseXML(List<TableData> tableNames, List<string> storedProcedureNames)
        {
            string fileName = Global.Setting.XmlAndLogFilePrefix + "Settings.xml";

            string filePath = string.Empty;
            var selectedItems = VisualStudioHelper.GetDTE().SelectedItems.Cast<SelectedItem>();
            if (selectedItems.Count() == 1)
            {
                SelectedItem item = selectedItems.FirstOrDefault();

                if (item.Project != null)
                {
                    Project p = VisualStudioHelper.FindProject(item.Project.Name);
                    filePath = VisualStudioHelper.GetProjectPath(item.Project);
                }
                else if (item.ProjectItem != null)
                {
                    filePath = VisualStudioHelper.GetProjectPath(item.ProjectItem.ContainingProject);
                }
            }

            filePath = Path.Combine(filePath, fileName);

            if (System.IO.File.Exists(filePath))
            {
                var xml = XDocument.Load(filePath);

                XElement settingNode = xml.Root.Descendants("DatabaseGenerationSetting").FirstOrDefault();
                XmlSerializer serializer = new XmlSerializer(typeof(DatabaseGenerationSetting));

                if (settingNode != null)
                {
                    StringReader rdr = new StringReader(settingNode.ToString().Replace(">True<", ">true<").Replace(">False<", ">false<"));
                    DatabaseGenerationSetting setting = (DatabaseGenerationSetting)serializer.Deserialize(rdr);
                    Global.InitializeSetting(setting);
                }

                List<XElement> tableNodes = (from c in xml.Root.Descendants("TableData") select c).ToList();
                serializer = new XmlSerializer(typeof(TableData));

                foreach (XElement item in tableNodes)
                {
                    StringReader rdr = new StringReader(item.ToString().Replace(">True<", ">true<").Replace(">False<", ">false<"));
                    tableNames.Add((TableData)serializer.Deserialize(rdr));
                }

                storedProcedureNames = (from c in xml.Root.Descendants("StoredProcedure")
                                        select c.Value).ToList();
            }
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

		public void StartNewFile(string fileName, string projectName = "", string folderName = "")
		{
			Indents = new List<string>();
			CurrentFile = new NewFile();

			CurrentFile.FileName = fileName;
			CurrentFile.ProjectName = projectName;
			CurrentFile.FolderName = folderName;
		}

        public virtual void CreateFiles()
        {

        }

		public void ProcessFiles()
		{
			var list = new List<NewFile>();

			if (NewFiles.Any())
			{
				// check selectitem first
				string defaultPath = string.Empty;
				string currentProjectName = string.Empty;
				Project selectedProject = null;

				var selectedItems = dte.SelectedItems.Cast<SelectedItem>();
				if (selectedItems.Count() == 1)
				{
					SelectedItem item = selectedItems.FirstOrDefault();

					if (item.Project != null)
					{
						selectedProject = VisualStudioHelper.FindProject(item.Project.Name);
						currentProjectName = item.Project.Name;
						defaultPath = VisualStudioHelper.GetProjectPath(item.Project);
					}
					else if (item.ProjectItem != null)
					{
						defaultPath = VisualStudioHelper.GetProjectPath(item.ProjectItem.ContainingProject);
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
					if(!string.IsNullOrEmpty(groupedFiles[x].FolderName))
					{
						Project p = null;

						if (string.IsNullOrEmpty(groupedFiles[x].ProjectName))
						{
							p = selectedProject;
						}
						else
						{
							p = VisualStudioHelper.FindProject(groupedFiles[x].ProjectName);
						}

						string path = VisualStudioHelper.GetProjectPath(p);

						if (!Directory.Exists(Path.Combine(path, groupedFiles[x].FolderName)))
						{
							p.ProjectItems.AddFolder(groupedFiles[x].FolderName);
						}
					}

					var outputPath = VisualStudioHelper.GetOutputPath(groupedFiles[x].ProjectName, groupedFiles[x].FolderName, defaultPath);
					var outputFiles = groupedFiles[x].OutputFiles;

					for (int i = 0; i < outputFiles.Length; i++)
					{
						var outputFile = NewFiles[i];

						if (outputFile.ProjectName == null)
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

				if (list.Count > 0)
				{
					SyncProjectsAction.EndInvoke(SyncProjectsAction.BeginInvoke(list, null, null));

					this.WriteLog(list);

					Stopwatch.Stop();
					Logger.AddLog("");
					Logger.AddLog($"// Total Time Elapsed: {Stopwatch.Elapsed.TotalSeconds}");

					list = new List<NewFile>();

					list.Add(CreateDatabaseSettingXmlFile(defaultPath, currentProjectName));
					list.Add(CreateLogFile(defaultPath, currentProjectName));

					SyncProjectsAction.EndInvoke(SyncProjectsAction.BeginInvoke(list, null, null));
				}
			}
		}

		private NewFile CreateDatabaseSettingXmlFile(string defaultPath, string projectName)
		{
			GenerationEnvironment = new StringBuilder();
			Indents = new List<string>();
			TotalIndentValue = string.Empty;

			WriteLine("<Database>");
			PushIndent("\t");

			WriteLine("<DatabaseGenerationSetting>");
			PushIndent("\t");

			WriteLine("<ProviderName>{0}</ProviderName>", Setting.ProviderName);
			WriteLine("<ConnectionStringName>{0}</ConnectionStringName>", Setting.ConnectionStringName);
			WriteLine("<DatabaseContextName>{0}</DatabaseContextName>", Setting.DatabaseContextName);
			WriteLine("<DatabaseContextInterfaceName>{0}</DatabaseContextInterfaceName>", Setting.DatabaseContextInterfaceName);
			WriteLine("<ContextInterfaceBaseClass>{0}</ContextInterfaceBaseClass>", Setting.ContextInterfaceBaseClass);
			WriteLine("<ContextBaseClass>{0}</ContextBaseClass>", Setting.ContextBaseClass);
			WriteLine("<MakeClassesPartial>{0}</MakeClassesPartial>", Setting.MakeClassesPartial);
			WriteLine("<MakeInterfacesPartial>{0}</MakeInterfacesPartial>", Setting.MakeInterfacesPartial);
			WriteLine("<MakeContextInterfacePartial>{0}</MakeContextInterfacePartial>", Setting.MakeContextInterfacePartial);
			WriteLine("<UseDataAnnotations>{0}</UseDataAnnotations>", Setting.UseDataAnnotations);
			WriteLine("<GenerateContextClass>{0}</GenerateContextClass>", Setting.GenerateContextClass);
			WriteLine("<GenerateUnitOfWorkInterface>{0}</GenerateUnitOfWorkInterface>", Setting.GenerateUnitOfWorkInterface);
			WriteLine("<VirtualReverseNavigationProperties>{0}</VirtualReverseNavigationProperties>", Setting.VirtualReverseNavigationProperties);
			WriteLine("<UseCamelCase>{0}</UseCamelCase>", Setting.UseCamelCase);
			WriteLine("<DisableGeographyTypes>{0}</DisableGeographyTypes>", Setting.DisableGeographyTypes);
			WriteLine("<NullableShortHand>{0}</NullableShortHand>", Setting.NullableShortHand);
			WriteLine("<PrivateSetterForComputedColumns>{0}</PrivateSetterForComputedColumns>", Setting.PrivateSetterForComputedColumns);
			WriteLine("<FileExtension>{0}</FileExtension>", Setting.FileExtension);
			WriteLine("<GeneratedFileExtension>{0}</GeneratedFileExtension>", Setting.GeneratedFileExtension);
			WriteLine("<PrependSchemaName>{0}</PrependSchemaName>", Setting.PrependSchemaName);
			WriteLine("<ConfigurationClassName>{0}</ConfigurationClassName>", Setting.ConfigurationClassName);
			WriteLine("<IncludeComments>{0}</IncludeComments>", Setting.IncludeComments);
			WriteLine("<IncludeQueryTraceOn9481Flag>{0}</IncludeQueryTraceOn9481Flag>", Setting.IncludeQueryTraceOn9481Flag);

			PopIndent();
			WriteLine("</DatabaseGenerationSetting>");

			WriteLine("<Tables>");
			PushIndent("\t");

			XmlSerializer serializer = new XmlSerializer(typeof(TableData));
			foreach (TableData tbl in Tables.Select(x => x.TableData).ToList())
			{
				WriteLine("<TableData>");
				PushIndent("\t");

				WriteLine("<TableSelect>{0}</TableSelect>", tbl.TableSelect);
				WriteLine("<TableName>{0}</TableName>", tbl.TableName);
				WriteLine("<GeneratePoco>{0}</GeneratePoco>", tbl.GeneratePoco);
				WriteLine("<GeneratePocoInterface>{0}</GeneratePocoInterface>", tbl.GeneratePocoInterface);
				WriteLine("<GenerateRepository>{0}</GenerateRepository>", tbl.GenerateRepository);
				WriteLine("<GenerateRepositoryInterface>{0}</GenerateRepositoryInterface>", tbl.GenerateRepositoryInterface);
				WriteLine("<GenerateService>{0}</GenerateService>", tbl.GenerateService);
				WriteLine("<GenerateServiceInterface>{0}</GenerateServiceInterface>", tbl.GenerateServiceInterface);

				PopIndent();
				WriteLine("</TableData>");
			}
			PopIndent();
			WriteLine("</Tables>");

			WriteLine("<StoredProcedures>");
			PushIndent("\t");
			foreach (StoredProcedure sproc in StoredProcedures)
			{
				WriteLine("<StoredProcedure>{0}</StoredProcedure>", sproc.Name);
			}
			PopIndent();
			WriteLine("</StoredProcedures>");

			PopIndent();
			WriteLine("</Database>");

			var outputPath = VSHelper.GetOutputPath(dte, projectName, string.Empty, defaultPath);

			NewFile file = new NewFile();

			file.FileName = Setting.XmlAndLogFilePrefix + "Settings.xml";
			file.ProjectName = projectName;
			file.FolderName = string.Empty;
			file.FilePath = Path.Combine(outputPath, file.FileName); ;
			file.FileContent = GenerationEnvironment.ToString();
			file.OutputPath = outputPath;

			CreateFile(file);

			return file;
		}

		private NewFile CreateLogFile(string defaultPath, string projectName)
		{
			StringBuilder logFileContent = new StringBuilder();

			logFileContent.AppendLine(Logger.Warnings.ToString());
			logFileContent.AppendLine();

			logFileContent.AppendLine(Logger.Errors.ToString());
			logFileContent.AppendLine();

			logFileContent.AppendLine(Logger.Logs.ToString());
			logFileContent.AppendLine();

			var outputPath = VSHelper.GetOutputPath(dte, projectName, string.Empty, defaultPath);

			NewFile file = new NewFile();

			file.FileName = Setting.XmlAndLogFilePrefix + "Log.cs";
			file.ProjectName = projectName;
			file.FolderName = string.Empty;
			file.FilePath = Path.Combine(outputPath, file.FileName); ;
			file.FileContent = logFileContent.ToString();
			file.OutputPath = outputPath;

			CreateFile(file);

			return file;
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
			Logger.AddLog("// Generated items");

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
			WriteLine("{0}", line);
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
