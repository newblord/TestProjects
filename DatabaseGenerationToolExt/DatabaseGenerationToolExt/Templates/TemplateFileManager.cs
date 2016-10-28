//using System.Core;
using System.Data;
using System.Data.Entity;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
//using Microsoft.VisualStudio.Shell.10.0;
//using Microsoft.VisualStudio.Shell.Interop;
//using Microsoft.VisualStudio.Shell.Interop;
using System;
//using System.Data.Objects;
using System.Linq;
using System.IO;
using System.Collections.Generic;
//using System.Data.Objects.DataClasses;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Text;
using Microsoft.VisualStudio.TextTemplating;

/// <summary>
/// Responsible for marking the various sections of the generation,
/// so they can be split up into separate files and projects
/// </summary>
/// <author>R. Leupold</author>
public class TemplateFileManager
{
	private ProjectItem templateProjectItem;
	private Action<string> checkOutAction;
	private Action<IEnumerable<OutputFile>> projectSyncAction;
	private DTE dte;

	/// <summary>
	/// Creates files with VS sync
	/// </summary>
	public static TemplateFileManager Create(object textTransformation)
	{
		DynamicTextTransformation2 transformation = DynamicTextTransformation2.Create(textTransformation);
		IDynamicHost2 host = transformation.Host;
		return new TemplateFileManager(transformation);
	}

	private readonly List<Block> files = new List<Block>();
	private readonly Block footer = new Block();
	private readonly Block header = new Block();
	private readonly DynamicTextTransformation2 _textTransformation;

	// reference to the GenerationEnvironment StringBuilder on the
	// TextTransformation object
	private readonly StringBuilder _generationEnvironment;

	private Block currentBlock;

	/// <summary>
	/// Initializes an TemplateFileManager Instance  with the
	/// TextTransformation (T4 generated class) that is currently running
	/// </summary>
	private TemplateFileManager(object textTransformation)
	{
		if (textTransformation == null)
		{
			throw new ArgumentNullException("textTransformation");
		}

		_textTransformation = DynamicTextTransformation2.Create(textTransformation);
		_generationEnvironment = _textTransformation.GenerationEnvironment;

		var hostServiceProvider = _textTransformation.Host.AsIServiceProvider();
		if (hostServiceProvider == null)
		{
			throw new ArgumentNullException("Could not obtain hostServiceProvider");
		}

		dte = (DTE)hostServiceProvider.GetService(typeof(DTE));
		if (dte == null)
		{
			throw new ArgumentNullException("Could not obtain DTE from host");
		}

		this.templateProjectItem = dte.Solution.FindProjectItem(_textTransformation.Host.TemplateFile);
		this.CanOverrideExistingFile = true;
		this.Encoding = System.Text.Encoding.UTF8;
		checkOutAction = fileName => dte.SourceControl.CheckOutItem(fileName);
		projectSyncAction = keepFileNames => ProjectSync(templateProjectItem, keepFileNames);
	}

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
	/// Marks the end of the last file if there was one, and starts a new
	/// and marks this point in generation as a new file.
	/// </summary>
	/// <param name="name">Filename</param>
	/// <param name="projectName">Name of the target project for the new file.</param>
	/// <param name="folderName">Name of the target folder for the new file.</param>
	/// <param name="fileProperties">File property settings in vs for the new File</param>
	public void StartNewFile(string name, string projectName = "", string folderName = "", FileProperties fileProperties = null)
	{
		if (String.IsNullOrWhiteSpace(name) == true)
		{
			throw new ArgumentException("name");
		}

		CurrentBlock = new Block
		{
			Name = name,
			ProjectName = projectName,
			FolderName = folderName,
			FileProperties = fileProperties ?? new FileProperties()
		};
	}

	public void StartFooter()
	{
		CurrentBlock = footer;
	}

	public void StartHeader()
	{
		CurrentBlock = header;
	}

    private Block CurrentBlock
	{
		get { return currentBlock; }
		set
		{
			if (CurrentBlock != null)
			{
				EndBlock();
			}

			if (value != null)
			{
				value.Start = _generationEnvironment.Length;
			}

			currentBlock = value;
		}
	}

	public void EndBlock()
	{
		if (CurrentBlock == null)
		{
			return;
		}

		CurrentBlock.Length = _generationEnvironment.Length - CurrentBlock.Start;

		if (CurrentBlock != header && CurrentBlock != footer)
		{
			files.Add(CurrentBlock);
		}

		currentBlock = null;
	}

	/// <summary>
	/// Produce the template output files.
	/// </summary>
	public virtual IEnumerable<OutputFile> Process(bool split = true)
	{
		var list = new List<OutputFile>();

		if (split)
		{
			EndBlock();

			var headerText = _generationEnvironment.ToString(header.Start, header.Length);
			var footerText = _generationEnvironment.ToString(footer.Start, footer.Length);

			files.Reverse(); // need to test with this commented out for Try 3

			var groupedFiles = (from f in files
									  group f by new { f.ProjectName, f.FolderName }
									  into l
									  select new
									  {
										  ProjectName = l.Key.ProjectName,
										  FolderName = l.Key.FolderName,
										  OutputFiles = l.ToArray()
									  }).ToArray();

			for (int i = 0; i < groupedFiles.Length; i++)
			{
				var outputPath = VSHelper.GetOutputPath(dte, groupedFiles[i].ProjectName, groupedFiles[i].FolderName, Path.GetDirectoryName(_textTransformation.Host.TemplateFile));

				var outputFiles = groupedFiles[i].OutputFiles;

				for (int x = 0; x < outputFiles.Length; x++)
				{
					var outputFile = outputFiles[x];

					var fileName = Path.Combine(outputPath, outputFile.Name);
					var content = this.ReplaceParameter(headerText, outputFile) +
					_generationEnvironment.ToString(outputFile.Start, outputFile.Length) +
					footerText;

					var file = new OutputFile
					{
						FileName = fileName,
						ProjectName = outputFile.ProjectName,
						FolderName = outputFile.FolderName,
						FileProperties = outputFile.FileProperties,
						Content = content,
						OutputPath = outputPath
					};

					CreateFile(file);
					_generationEnvironment.Remove(outputFile.Start, outputFile.Length);

					list.Add(file);
				}
			}

		}

		if (list.Count > 0)
		{
			projectSyncAction.EndInvoke(projectSyncAction.BeginInvoke(list, null, null));

			this.WriteLog(list.ToArray());
		}

		return list;
	}

	private string ReplaceParameter(string text, Block block)
	{
		if (String.IsNullOrEmpty(text) == false)
		{
			text = text.Replace("$filename$", block.Name);
		}

		foreach (var item in block.FileProperties.TemplateParameter.AsEnumerable())
		{
			text = text.Replace(item.Key, item.Value);
		}

		return text;
	}

	/// <summary>
	/// Write log to the default output file.
	/// </summary>
	/// <param name="list"></param>
	private void WriteLog(OutputFile[] list)
	{
		for (int i = 0; i < list.Count(); i++)
		{
			this._textTransformation.WriteLine("// " + this.GetDirectorySolutionRelative(list[i].FileName));
		}
	}

	private string GetDirectorySolutionRelative(string fullName)
	{
		int slnPos = fullName.IndexOf(Path.GetFileNameWithoutExtension(this.dte.Solution.FileName));
		if (slnPos < 0)
		{
			slnPos = 0;
		}

		return fullName.Substring(slnPos);
	}

	protected virtual void CreateFile(OutputFile file)
	{
		if (this.CanOverrideExistingFile == false && File.Exists(file.FileName) == true)
		{
			return;
		}

		if (IsFileContentDifferent(file))
		{
			CheckoutFileIfRequired(file.FileName);
			File.WriteAllText(file.FileName, file.Content, this.Encoding);
		}
	}

	protected bool IsFileContentDifferent(OutputFile file)
	{
		return !(File.Exists(file.FileName) && File.ReadAllText(file.FileName) == file.Content);
	}

	private void ProjectSync(ProjectItem templateProjectItem, IEnumerable<OutputFile> keepFileNames)
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
			if (String.IsNullOrEmpty(item.ProjectName) == true && String.IsNullOrEmpty(item.FolderName) == true)
			{
				ProjectItemSyncPart(templateProjectItem, item.OutputFiles);
			}
			else
			{
				ProjectItem pi = VSHelper.FindProjectItem(templateProjectItem.DTE, item.FirstItem, templateProjectItem);

				if (pi != null)
				{
					Project prj = VSHelper.GetProject(templateProjectItem.DTE, item.ProjectName);
					prj.ProjectItems.AddFromDirectory(Path.GetDirectoryName(pi.FileNames[0]));

					if (!prj.Saved)
					{
						prj.Save();
					}
				}
				else
				{
					Project prj = VSHelper.GetProject(templateProjectItem.DTE, item.FirstItem.ProjectName);
					ProjectSyncPart(prj, item.OutputFiles);
				}
			}
		}

		// clean up
		bool hasDefaultItems = groupedFileNames.Where(f => String.IsNullOrEmpty(f.ProjectName) && String.IsNullOrEmpty(f.FolderName)).Count() > 0;
		if (hasDefaultItems == false)
		{
			ProjectItemSyncPart(templateProjectItem, new List<OutputFile>());
		}
	}

	private static void ProjectSyncPart(Project project, IEnumerable<OutputFile> keepFileNames)
	{
		var keepFileNameSet = new HashSet<OutputFile>(keepFileNames);

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
				project.ProjectItems.AddFromFile(fileName.FileName);
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
		checkOutAction.EndInvoke(checkOutAction.BeginInvoke(fileName, null, null));
	}
}

/// <summary>
/// Responsible creating an instance that can be passed
/// to helper classes that need to access the TextTransformation
/// members.  It accesses member by name and signature rather than
/// by type.  This is necessary when the
/// template is being used in Preprocessed mode
/// and there is no common known type that can be
/// passed instead
/// </summary>
public class DynamicTextTransformation2
{
	private object _instance;
	IDynamicHost2 _dynamicHost;

	private readonly MethodInfo _write;
	private readonly MethodInfo _writeLine;
	private readonly PropertyInfo _generationEnvironment;
	private readonly PropertyInfo _errors;
	private readonly PropertyInfo _host;

	/// <summary>
	/// Creates an instance of the DynamicTextTransformation class around the passed in
	/// TextTransformation shapped instance passed in, or if the passed in instance
	/// already is a DynamicTextTransformation, it casts it and sends it back.
	/// </summary>
	public static DynamicTextTransformation2 Create(object instance)
	{
		if (instance == null)
		{
			throw new ArgumentNullException("instance");
		}

		DynamicTextTransformation2 textTransformation = instance as DynamicTextTransformation2;
		if (textTransformation != null)
		{
			return textTransformation;
		}

		return new DynamicTextTransformation2(instance);
	}

	private DynamicTextTransformation2(object instance)
	{
		_instance = instance;
		Type type = _instance.GetType();
		_write = type.GetMethod("Write", new Type[] { typeof(string) });
		_writeLine = type.GetMethod("WriteLine", new Type[] { typeof(string) });
		_generationEnvironment = type.GetProperty("GenerationEnvironment", BindingFlags.Instance | BindingFlags.NonPublic);
		_host = type.GetProperty("Host");
		_errors = type.GetProperty("Errors");
	}

	/// <summary>
	/// Gets the value of the wrapped TextTranformation instance's GenerationEnvironment property
	/// </summary>
	public StringBuilder GenerationEnvironment { get { return (StringBuilder)_generationEnvironment.GetValue(_instance, null); } }

	/// <summary>
	/// Gets the value of the wrapped TextTranformation instance's Errors property
	/// </summary>
	public System.CodeDom.Compiler.CompilerErrorCollection Errors { get { return (System.CodeDom.Compiler.CompilerErrorCollection)_errors.GetValue(_instance, null); } }

	/// <summary>
	/// Calls the wrapped TextTranformation instance's Write method.
	/// </summary>
	public void Write(string text)
	{
		_write.Invoke(_instance, new object[] { text });
	}

	/// <summary>
	/// Calls the wrapped TextTranformation instance's WriteLine method.
	/// </summary>
	public void WriteLine(string text)
	{
		_writeLine.Invoke(_instance, new object[] { text });
	}

	/// <summary>
	/// Gets the value of the wrapped TextTranformation instance's Host property
	/// if available (shows up when hostspecific is set to true in the template directive) and returns
	/// the appropriate implementation of IDynamicHost
	/// </summary>
	public IDynamicHost2 Host
	{
		get
		{
			if (_dynamicHost == null)
			{
				if (_host == null)
				{
					_dynamicHost = new NullHost2();
				}
				else
				{
					_dynamicHost = new DynamicHost2(_host.GetValue(_instance, null));
				}
			}
			return _dynamicHost;
		}
	}
}

/// <summary>
/// Reponsible for abstracting the use of Host between times
/// when it is available and not
/// </summary>
public interface IDynamicHost2
{
	/// <summary>
	/// An abstracted call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolveParameterValue
	/// </summary>
	string ResolveParameterValue(string id, string name, string otherName);

	/// <summary>
	/// An abstracted call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolvePath
	/// </summary>
	string ResolvePath(string path);

	/// <summary>
	/// An abstracted call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost TemplateFile
	/// </summary>
	string TemplateFile { get; }

	/// <summary>
	/// Returns the Host instance cast as an IServiceProvider
	/// </summary>
	IServiceProvider AsIServiceProvider();
}

/// <summary>
/// Reponsible for implementing the IDynamicHost as a dynamic
/// shape wrapper over the Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost interface
/// rather than type dependent wrapper.  We don't use the
/// interface type so that the code can be run in preprocessed mode
/// on a .net framework only installed machine.
/// </summary>
public class DynamicHost2 : IDynamicHost2
{
	private readonly object _instance;
	private readonly MethodInfo _resolveParameterValue;
	private readonly MethodInfo _resolvePath;
	private readonly PropertyInfo _templateFile;

	/// <summary>
	/// Creates an instance of the DynamicHost class around the passed in
	/// Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost shapped instance passed in.
	/// </summary>
	public DynamicHost2(object instance)
	{
		_instance = instance;
		Type type = _instance.GetType();
		_resolveParameterValue = type.GetMethod("ResolveParameterValue", new Type[] { typeof(string), typeof(string), typeof(string) });
		_resolvePath = type.GetMethod("ResolvePath", new Type[] { typeof(string) });
		_templateFile = type.GetProperty("TemplateFile");
	}

	/// <summary>
	/// A call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolveParameterValue
	/// </summary>
	public string ResolveParameterValue(string id, string name, string otherName)
	{
		return (string)_resolveParameterValue.Invoke(_instance, new object[] { id, name, otherName });
	}

	/// <summary>
	/// A call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolvePath
	/// </summary>
	public string ResolvePath(string path)
	{
		return (string)_resolvePath.Invoke(_instance, new object[] { path });
	}

	/// <summary>
	/// A call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost TemplateFile
	/// </summary>
	public string TemplateFile
	{
		get
		{
			return (string)_templateFile.GetValue(_instance, null);
		}
	}

	/// <summary>
	/// Returns the Host instance cast as an IServiceProvider
	/// </summary>
	public IServiceProvider AsIServiceProvider()
	{
		return _instance as IServiceProvider;
	}
}

/// <summary>
/// Reponsible for implementing the IDynamicHost when the
/// Host property is not available on the TextTemplating type. The Host
/// property only exists when the hostspecific attribute of the template
/// directive is set to true.
/// </summary>
public class NullHost2 : IDynamicHost2
{
	/// <summary>
	/// An abstraction of the call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolveParameterValue
	/// that simply retuns null.
	/// </summary>
	public string ResolveParameterValue(string id, string name, string otherName)
	{
		return null;
	}

	/// <summary>
	/// An abstraction of the call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost ResolvePath
	/// that simply retuns the path passed in.
	/// </summary>
	public string ResolvePath(string path)
	{
		return path;
	}

	/// <summary>
	/// An abstraction of the call to Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost TemplateFile
	/// that returns null.
	/// </summary>
	public string TemplateFile
	{
		get
		{
			return null;
		}
	}

	/// <summary>
	/// Returns null.
	/// </summary>
	public IServiceProvider AsIServiceProvider()
	{
		return null;
	}
}

public sealed class Block
{
	public String Name;
	public int Start, Length;
	public string ProjectName { get; set; }
	public string FolderName { get; set; }
	public FileProperties FileProperties { get; set; }
}

public class VSHelper
{
	/// <summary>
	/// Execute Visual Studio commands against the project item.
	/// </summary>
	/// <param name="item">The current project item.</param>
	/// <param name="command">The vs command as string.</param>
	/// <returns>An error message if the command fails.</returns>
	public static string ExecuteVsCommand(DTE dte, ProjectItem item, params string[] command)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}

		string error = String.Empty;

		try
		{
			Window window = item.Open();
			window.Activate();

			foreach (var cmd in command)
			{
				if (String.IsNullOrWhiteSpace(cmd) == true)
				{
					continue;
				}

				EnvDTE80.DTE2 dte2 = dte as EnvDTE80.DTE2;
				dte2.ExecuteCommand(cmd, String.Empty);
			}

			item.Save();
			window.Visible = false;
			// window.Close(); // Ends VS, but not the tab :(
		}
		catch (Exception ex)
		{
			error = String.Format("Error processing file {0} {1}", item.Name, ex.Message);
		}

		return error;
	}

	/// <summary>
	/// Sets a property value for the vs project item.
	/// </summary>
	public static void SetPropertyValue(ProjectItem item, string propertyName, object value)
	{
		Property property = item.Properties.Item(propertyName);
		if (property == null)
		{
			throw new ArgumentException(String.Format("The property {0} was not found.", propertyName));
		}
		else
		{
			property.Value = value;
		}
	}

	public static string GetOutputPath(DTE dte, string projectName, string folderName, string defaultPath)
	{
		if (String.IsNullOrEmpty(projectName) == true && String.IsNullOrEmpty(folderName) == true)
		{
			return defaultPath;
		}

		Project prj = null;
		ProjectItem item = null;

		if (String.IsNullOrEmpty(projectName) == false)
		{
			prj = GetProject(dte, projectName);
		}

		if (String.IsNullOrEmpty(folderName) == true && prj != null)
		{
			return Path.GetDirectoryName(prj.FullName);
		}
		else if (prj != null && String.IsNullOrEmpty(folderName) == false)
		{
			item = GetAllProjectItemsRecursive(prj.ProjectItems).Where(i => i.Name == folderName).First();
		}
		else if (String.IsNullOrEmpty(folderName) == false)
		{
			item = GetAllProjectItemsRecursive(dte.ActiveDocument.ProjectItem.ContainingProject.ProjectItems)
					.Where(i => i.Name == folderName).First();
		}

		if (item != null)
		{
			return GetProjectItemFullPath(item);
		}

		return defaultPath;
	}

	public static ProjectItem FindProjectItem(DTE dte, OutputFile file, ProjectItem defaultItem)
	{
		if (String.IsNullOrEmpty(file.ProjectName) == true && String.IsNullOrEmpty(file.FolderName) == true)
		{
			return defaultItem;
		}

		Project prj = null;
		ProjectItem item = null;

		if (String.IsNullOrEmpty(file.ProjectName) == false)
		{
			prj = GetProject(dte, file.ProjectName);
		}

		if (String.IsNullOrEmpty(file.FolderName) == true && prj != null)
		{
			return null;
		}
		else if (prj != null && String.IsNullOrEmpty(file.FolderName) == false)
		{
			item = GetAllProjectItemsRecursive(prj.ProjectItems).Where(i => i.Name == file.FolderName).First();
		}
		else if (String.IsNullOrEmpty(file.FolderName) == false)
		{
			item = GetAllProjectItemsRecursive(dte.ActiveDocument.ProjectItem.ContainingProject.ProjectItems)
					.Where(i => i.Name == file.FolderName).First();
		}

		if (item != null)
		{
			return item;
		}

		return defaultItem;
	}

	private static ProjectItem FindProjectItem(ProjectItems items, string fullName, bool canCreateIfNotExists)
	{
		ProjectItem item = (from i in items.Cast<ProjectItem>()
											where i.Name == Path.GetFileName(fullName)
											select i).FirstOrDefault();
		if (item == null)
		{
			File.CreateText(fullName);
			item = items.AddFromFile(fullName);
		}

		return item;
	}

	public static Project GetProject(DTE dte, string projectName)
	{
		return GetAllProjects(dte).Where(p => p.Name == projectName).First();
	}

	public static IEnumerable<Project> GetAllProjects(DTE dte)
	{
		List<Project> projectList = new List<Project>();

		var folders = dte.Solution.Projects.Cast<Project>().Where(p => p.Kind == EnvDTE80.ProjectKinds.vsProjectKindSolutionFolder);

		foreach (Project folder in folders)
		{
			if (folder.ProjectItems == null) continue;

			foreach (ProjectItem item in folder.ProjectItems)
			{
				if (item.Object is Project)
					projectList.Add(item.Object as Project);
			}
		}

		var projects = dte.Solution.Projects.Cast<Project>().Where(p => p.Kind != EnvDTE80.ProjectKinds.vsProjectKindSolutionFolder);

		if (projects.Count() > 0)
			projectList.AddRange(projects);

		return projectList;
	}

	public static ProjectItem GetProjectItemWithName(ProjectItems items, string itemName)
	{
		return GetAllProjectItemsRecursive(items).Cast<ProjectItem>().Where(i => i.Name == itemName).First();
	}

	public static string GetProjectItemFullPath(ProjectItem item)
	{
		return item.Properties.Item("FullPath").Value.ToString();
	}

	public static IEnumerable<ProjectItem> GetAllSolutionItems(DTE dte)
	{
		List<ProjectItem> itemList = new List<ProjectItem>();

		foreach (Project item in GetAllProjects(dte))
		{
			if (item == null || item.ProjectItems == null) continue;

			itemList.AddRange(GetAllProjectItemsRecursive(item.ProjectItems));
		}

		return itemList;
	}

	public static IEnumerable<ProjectItem> GetAllProjectItemsRecursive(ProjectItems projectItems)
	{
		foreach (ProjectItem projectItem in projectItems)
		{
			if (projectItem.ProjectItems == null) continue;

			foreach (ProjectItem subItem in GetAllProjectItemsRecursive(projectItem.ProjectItems))
			{
				yield return subItem;
			}

			yield return projectItem;
		}
	}

}

public sealed class OutputFile
{
	public OutputFile()
	{
		this.FileProperties = new FileProperties
		{
			CustomTool = String.Empty,
			BuildAction = BuildAction.None
		};
	}

	public string FileName { get; set; }
	public string ProjectName { get; set; }
	public string FolderName { get; set; }
	public string Content { get; set; }
	public FileProperties FileProperties { get; set; }
	public string OutputPath { get; set; }
}

public class BuildAction
{
	public const string None = "None";
	public const string Compile = "Compile";
	public const string Content = "Content";
	public const string EmbeddedResource = "EmbeddedResource";
	public const string EntityDeploy = "EntityDeploy";
}

public sealed class FileProperties
{
	public FileProperties()
	{
		this.TemplateParameter = new Dictionary<string, string>();
	}

	public string CustomTool { get; set; }
	public string BuildAction { get; set; }
	public Dictionary<string, string> TemplateParameter { get; set; }

	internal string BuildActionString
	{
		get
		{
			return this.BuildAction;
		}
	}
}
