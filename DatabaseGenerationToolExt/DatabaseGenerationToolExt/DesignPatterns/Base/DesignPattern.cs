using System.Globalization;
using DatabaseGenerationToolExt.DesignPatterns.Models;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DatabaseGenerationToolExt.Helpers;
using EnvDTE;
using System.Xml.Serialization;
using System.Xml.Linq;
using DatabaseGenerationToolExt.DatabaseGeneration.Models;
using DatabaseGenerationToolExt.DatabaseGeneration.Settings;

namespace DatabaseGenerationToolExt.DesignPatterns
{
	public abstract class DesignPattern
	{

		public DesignPattern(string targetFrameworkVersion, Tables tables, List<StoredProcedure> storedProcs, List<DatabaseGeneration.Models.Enum> enums)
		{
			TargetFrameworkVersion = targetFrameworkVersion;
			Tables = tables;
			StoredProcedures = storedProcs;
			Enums = enums;
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

		protected DatabaseGenerationSetting DatabaseSetting
		{
			get
			{
				return Global.DatabaseSetting;
			}
		}

		protected ProjectSetting ProjectSetting
		{
			get
			{
				return Global.ProjectSetting;
			}
		}

		public Tables Tables { get; set; }

		public List<StoredProcedure> StoredProcedures { get; set; }

		public List<DatabaseGeneration.Models.Enum> Enums { get; set; }

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

		public static void ProcessDatabaseXML()
		{
			string fileName = Global.DatabaseSetting.XmlAndLogFilePrefix + "Settings.xml";

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
					Global.DatabaseSetting = setting;
				}

				XElement projectSettingNode = xml.Root.Descendants("ProjectSetting").FirstOrDefault();
				serializer = new XmlSerializer(typeof(ProjectSetting));

				if (projectSettingNode != null)
				{
					StringReader rdr = new StringReader(projectSettingNode.ToString());
					ProjectSetting setting = (ProjectSetting)serializer.Deserialize(rdr);
					Global.ProjectSetting = setting;
				}

				List<XElement> tableNodes = (from c in xml.Root.Descendants("TableData") select c).ToList();
				serializer = new XmlSerializer(typeof(Forms.Models.TableData));

				foreach (XElement item in tableNodes)
				{
					StringReader rdr = new StringReader(item.ToString().Replace(">True<", ">true<").Replace(">False<", ">false<"));
					Global.SelectedTables.Add((Forms.Models.TableData)serializer.Deserialize(rdr));
				}

				List<XElement> sprocNodes = (from c in xml.Root.Descendants("StoredProcedureData") select c).ToList();
				serializer = new XmlSerializer(typeof(Forms.Models.StoredProcedureData));

				foreach (XElement item in sprocNodes)
				{
					StringReader rdr = new StringReader(item.ToString().Replace(">True<", ">true<").Replace(">False<", ">false<"));
					Global.SelectedStoredProcedures.Add((Forms.Models.StoredProcedureData)serializer.Deserialize(rdr));
				}

				List<XElement> enumNodes = (from c in xml.Root.Descendants("EnumData") select c).ToList();
				serializer = new XmlSerializer(typeof(Forms.Models.EnumData));

				foreach (XElement item in enumNodes)
				{
					StringReader rdr = new StringReader(item.ToString().Replace(">True<", ">true<").Replace(">False<", ">false<"));
					Global.SelectedEnums.Add((Forms.Models.EnumData)serializer.Deserialize(rdr));
				}
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
					if (!string.IsNullOrEmpty(groupedFiles[x].FolderName))
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

					var projectName = string.IsNullOrEmpty(groupedFiles[x].ProjectName) ? currentProjectName : groupedFiles[x].ProjectName;
					var outputPath = VisualStudioHelper.GetOutputPath(projectName, groupedFiles[x].FolderName, defaultPath);
					var outputFiles = groupedFiles[x].OutputFiles;

					for (int i = 0; i < outputFiles.Length; i++)
					{
						var outputFile = outputFiles[i];

						if (string.IsNullOrEmpty(outputFile.ProjectName))
						{
							outputFile.ProjectName = projectName;
						}

						outputFile.FilePath = Path.Combine(outputPath, outputFile.FileName);
						outputFile.FileContent = GenerationEnvironment.ToString(outputFile.Start, outputFile.Length);
						outputFile.OutputPath = outputPath;

						bool isFileCreated = CreateFile(outputFile);
						GenerationEnvironment.Remove(outputFile.Start, outputFile.Length);

						if(isFileCreated)
						{
							list.Add(outputFile);
						}
					}

					if (list.Count > 0)
					{
						SyncProjectsAction.EndInvoke(SyncProjectsAction.BeginInvoke(list, null, null));
					}
				}

				Stopwatch.Stop();
				Logger.AddLog("");
				Logger.AddLog($"// Total Time Elapsed: {Stopwatch.Elapsed.TotalSeconds}");

				list = new List<NewFile>();

				list.Add(CreateDatabaseXmlFile(defaultPath, currentProjectName));
				list.Add(CreateLogFile(defaultPath, currentProjectName));

				SyncProjectsAction.EndInvoke(SyncProjectsAction.BeginInvoke(list, null, null));
			}
		}

		private NewFile CreateDatabaseXmlFile(string defaultPath, string projectName)
		{
			GenerationEnvironment = new StringBuilder();
			Indents = new List<string>();
			TotalIndentValue = string.Empty;

			WriteLine("<Database>");
			PushIndent("\t");

			WriteLine("<DatabaseGenerationSetting>");
			PushIndent("\t");

			WriteLine("<ProviderName>{0}</ProviderName>", DatabaseSetting.ProviderName);
			WriteLine("<ConnectionStringName>{0}</ConnectionStringName>", DatabaseSetting.ConnectionStringName);
			WriteLine("<DatabaseContextName>{0}</DatabaseContextName>", DatabaseSetting.DatabaseContextName);
			WriteLine("<DatabaseContextInterfaceName>{0}</DatabaseContextInterfaceName>", DatabaseSetting.DatabaseContextInterfaceName);
			WriteLine("<ContextInterfaceBaseClass>{0}</ContextInterfaceBaseClass>", DatabaseSetting.ContextInterfaceBaseClass);
			WriteLine("<ContextBaseClass>{0}</ContextBaseClass>", DatabaseSetting.ContextBaseClass);
			WriteLine("<MakeClassesPartial>{0}</MakeClassesPartial>", DatabaseSetting.MakeClassesPartial);
			WriteLine("<MakeInterfacesPartial>{0}</MakeInterfacesPartial>", DatabaseSetting.MakeInterfacesPartial);
			WriteLine("<MakeContextInterfacePartial>{0}</MakeContextInterfacePartial>", DatabaseSetting.MakeContextInterfacePartial);
			WriteLine("<UseDataAnnotations>{0}</UseDataAnnotations>", DatabaseSetting.UseDataAnnotations);
			WriteLine("<GenerateContextClass>{0}</GenerateContextClass>", DatabaseSetting.GenerateContextClass);
			WriteLine("<GenerateUnitOfWorkInterface>{0}</GenerateUnitOfWorkInterface>", DatabaseSetting.GenerateUnitOfWorkInterface);
			WriteLine("<VirtualReverseNavigationProperties>{0}</VirtualReverseNavigationProperties>", DatabaseSetting.VirtualReverseNavigationProperties);
			WriteLine("<UseCamelCase>{0}</UseCamelCase>", DatabaseSetting.UseCamelCase);
			WriteLine("<DisableGeographyTypes>{0}</DisableGeographyTypes>", DatabaseSetting.DisableGeographyTypes);
			WriteLine("<NullableShortHand>{0}</NullableShortHand>", DatabaseSetting.NullableShortHand);
			WriteLine("<FileExtension>{0}</FileExtension>", DatabaseSetting.FileExtension);
			WriteLine("<GeneratedFileExtension>{0}</GeneratedFileExtension>", DatabaseSetting.GeneratedFileExtension);
			WriteLine("<PrependSchemaName>{0}</PrependSchemaName>", DatabaseSetting.PrependSchemaName);
			WriteLine("<ConfigurationClassName>{0}</ConfigurationClassName>", DatabaseSetting.ConfigurationClassName);
			WriteLine("<IncludeComments>{0}</IncludeComments>", DatabaseSetting.IncludeComments);
			WriteLine("<IncludeQueryTraceOn9481Flag>{0}</IncludeQueryTraceOn9481Flag>", DatabaseSetting.IncludeQueryTraceOn9481Flag);

			PopIndent();
			WriteLine("</DatabaseGenerationSetting>");

			WriteLine("<ProjectSetting>");
			PushIndent("\t");

			WriteLine("<ConfigurationFolderName>{0}</ConfigurationFolderName>", ProjectSetting.ConfigurationFolderName);
			WriteLine("<ConfigurationProjectName>{0}</ConfigurationProjectName>", ProjectSetting.ConfigurationProjectName);
			WriteLine("<ContextFolderName>{0}</ContextFolderName>", ProjectSetting.ContextFolderName);
			WriteLine("<ContextProjectName>{0}</ContextProjectName>", ProjectSetting.ContextProjectName);
			WriteLine("<ModelFolderName>{0}</ModelFolderName>", ProjectSetting.ModelFolderName);
			WriteLine("<ModelProjectName>{0}</ModelProjectName>", ProjectSetting.ModelProjectName);
			WriteLine("<ModelInterfaceFolderName>{0}</ModelInterfaceFolderName>", ProjectSetting.ModelInterfaceFolderName);
			WriteLine("<ModelInterfaceProjectName>{0}</ModelInterfaceProjectName>", ProjectSetting.ModelInterfaceProjectName);
			WriteLine("<ModelDtoFolderName>{0}</ModelDtoFolderName>", ProjectSetting.ModelDtoFolderName);
			WriteLine("<ModelDtoProjectName>{0}</ModelDtoProjectName>", ProjectSetting.ModelDtoProjectName);
			WriteLine("<RepositoryFolderName>{0}</RepositoryFolderName>", ProjectSetting.RepositoryFolderName);
			WriteLine("<RepositoryProjectName>{0}</RepositoryProjectName>", ProjectSetting.RepositoryProjectName);
			WriteLine("<RepositoryInterfaceFolderName>{0}</RepositoryInterfaceFolderName>", ProjectSetting.RepositoryInterfaceFolderName);
			WriteLine("<RepositoryInterfaceProjectName>{0}</RepositoryInterfaceProjectName>", ProjectSetting.RepositoryInterfaceProjectName);
			WriteLine("<SpecificationFolderName>{0}</SpecificationFolderName>", ProjectSetting.SpecificationFolderName);
			WriteLine("<SpecificationProjectName>{0}</SpecificationProjectName>", ProjectSetting.SpecificationProjectName);
			WriteLine("<ServiceFolderName>{0}</ServiceFolderName>", ProjectSetting.ServiceFolderName);
			WriteLine("<ServiceProjectName>{0}</ServiceProjectName>", ProjectSetting.ServiceProjectName);
			WriteLine("<ServiceInterfaceFolderName>{0}</ServiceInterfaceFolderName>", ProjectSetting.ServiceInterfaceFolderName);
			WriteLine("<ServiceInterfaceProjectName>{0}</ServiceInterfaceProjectName>", ProjectSetting.ServiceInterfaceProjectName);

			WriteLine("<ContextNamespace>{0}</ContextNamespace>", ProjectSetting.ContextNamespace);
			WriteLine("<ModelInterfaceNamespace>{0}</ModelInterfaceNamespace>", ProjectSetting.ModelInterfaceNamespace);
			WriteLine("<ModelDtoNamespace>{0}</ModelDtoNamespace>", ProjectSetting.ModelDtoNamespace);
			WriteLine("<ModelNamespace>{0}</ModelNamespace>", ProjectSetting.ModelNamespace);
			WriteLine("<ModelConfigurationNamespace>{0}</ModelConfigurationNamespace>", ProjectSetting.ConfigurationNamespace);
			WriteLine("<RepositoryInterfaceNamespace>{0}</RepositoryInterfaceNamespace>", ProjectSetting.RepositoryInterfaceNamespace);
			WriteLine("<RepositoryNamespace>{0}</RepositoryNamespace>", ProjectSetting.RepositoryNamespace);
			WriteLine("<SpecificationNamespace>{0}</SpecificationNamespace>", ProjectSetting.SpecificationNamespace);
			WriteLine("<ServiceInterfaceNamespace>{0}</ServiceInterfaceNamespace>", ProjectSetting.ServiceInterfaceNamespace);
			WriteLine("<ServiceNamespace>{0}</ServiceNamespace>", ProjectSetting.ServiceNamespace);
			WriteLine("<UnitOfWorkNamespace>{0}</UnitOfWorkNamespace>", ProjectSetting.UnitOfWorkNamespace);

			PopIndent();
			WriteLine("</ProjectSetting>");

			WriteLine("<Tables>");
			PushIndent("\t");

			XmlSerializer serializer = new XmlSerializer(typeof(Forms.Models.TableData));
			foreach (Forms.Models.TableData tbl in Tables.Select(x => x.TableData).OrderBy(x => x.TableName))
			{
				WriteLine("<TableData>");
				PushIndent("\t");

				WriteLine("<TableSelect>{0}</TableSelect>", tbl.TableSelect);
				WriteLine("<TableName>{0}</TableName>", tbl.TableName);
				WriteLine("<GenerateModelInterface>{0}</GenerateModelInterface>", tbl.GenerateModelInterface);
				WriteLine("<GenerateModelDto>{0}</GenerateModelDto>", tbl.GenerateModelDto);
				WriteLine("<GenerateRepository>{0}</GenerateRepository>", tbl.GenerateRepository);
				WriteLine("<GenerateRepositoryInterface>{0}</GenerateRepositoryInterface>", tbl.GenerateRepositoryInterface);
				WriteLine("<GenerateService>{0}</GenerateService>", tbl.GenerateService);
				WriteLine("<GenerateServiceInterface>{0}</GenerateServiceInterface>", tbl.GenerateServiceInterface);
				WriteLine("<GenerateSpecification>{0}</GenerateSpecification>", tbl.GenerateSpecification);

				PopIndent();
				WriteLine("</TableData>");
			}
			PopIndent();
			WriteLine("</Tables>");

			WriteLine("<StoredProcedures>");
			PushIndent("\t");
			foreach (Forms.Models.StoredProcedureData sproc in StoredProcedures.Select(x => x.StoredProcData).OrderBy(x => x.StoredProcName))
			{
				WriteLine("<StoredProcedureData>");
				PushIndent("\t");

				WriteLine("<StoredProcSelect>{0}</StoredProcSelect>", sproc.StoredProcSelect);
				WriteLine("<StoredProcName>{0}</StoredProcName>", sproc.StoredProcName);

				PopIndent();
				WriteLine("</StoredProcedureData>");
			}
			PopIndent();
			WriteLine("</StoredProcedures>");

			WriteLine("<Enums>");
			PushIndent("\t");
			foreach (Forms.Models.EnumData e in Enums.Select(x => x.EnumData).OrderBy(x => x.EnumName))
			{
				WriteLine("<EnumData>");
				PushIndent("\t");

				WriteLine("<EnumSelect>{0}</EnumSelect>", e.EnumSelect);
				WriteLine("<EnumName>{0}</EnumName>", e.EnumName);

				PopIndent();
				WriteLine("</EnumData>");
			}
			PopIndent();
			WriteLine("</Enums>");

			PopIndent();
			WriteLine("</Database>");

			var outputPath = VisualStudioHelper.GetOutputPath(projectName, string.Empty, defaultPath);

			NewFile file = new NewFile();

			file.FileName = DatabaseSetting.XmlAndLogFilePrefix + "Settings.xml";
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

			var outputPath = VisualStudioHelper.GetOutputPath(projectName, string.Empty, defaultPath);

			NewFile file = new NewFile();

			file.FileName = DatabaseSetting.XmlAndLogFilePrefix + "Log.cs";
			file.ProjectName = projectName;
			file.FolderName = string.Empty;
			file.FilePath = Path.Combine(outputPath, file.FileName); ;
			file.FileContent = logFileContent.ToString();
			file.OutputPath = outputPath;

			CreateFile(file);

			return file;
		}

		private bool CreateFile(NewFile file)
		{
			if (IsFileContentDifferent(file))
			{
				File.WriteAllText(file.FilePath, file.FileContent);
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool IsFileContentDifferent(NewFile file)
		{
			return !(File.Exists(file.FilePath) && File.ReadAllText(file.FilePath) == file.FileContent);
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

		private static void ProjectItemSyncPart(ProjectItem templateProjectItem, IEnumerable<NewFile> keepFileNames)
		{
			var keepFileNameSet = new HashSet<NewFile>(keepFileNames);
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

		public virtual void OpenBrace()
		{
			WriteLine("{");
			PushIndent("\t");
		}

		public virtual void CloseBrace()
		{
			PopIndent();
			WriteLine("}");
			WriteLine("");
		}

		#endregion
	}
}
