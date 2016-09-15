﻿//using System.Core;
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
	private EnvDTE.ProjectItem templateProjectItem;
	private Action<string> checkOutAction;
	private Action<IEnumerable<OutputFile>> projectSyncAction;
	private EnvDTE.DTE dte;
	private List<string> templatePlaceholderList = new List<string>();

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

		dte = (EnvDTE.DTE)hostServiceProvider.GetService(typeof(EnvDTE.DTE));
		if (dte == null)
		{
			throw new ArgumentNullException("Could not obtain DTE from host");
		}

		this.templateProjectItem = dte.Solution.FindProjectItem(_textTransformation.Host.TemplateFile);
		this.CanOverrideExistingFile = true;
		this.IsAutoIndentEnabled = false;
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
	/// If set to true, output files (c#, vb) are formatted based on the vs settings.
	/// </summary>
	/// <returns></returns>
	public bool IsAutoIndentEnabled { get; set; }

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
			files.Reverse();

			foreach (var block in files)
			{
				var outputPath = VSHelper.GetOutputPath(dte, block, Path.GetDirectoryName(_textTransformation.Host.TemplateFile));
				var fileName = Path.Combine(outputPath, block.Name);
				var content = this.ReplaceParameter(headerText, block) +
				_generationEnvironment.ToString(block.Start, block.Length) +
				footerText;

				var file = new OutputFile
				{
					FileName = fileName,
					ProjectName = block.ProjectName,
					FolderName = block.FolderName,
					FileProperties = block.FileProperties,
					Content = content
				};

				CreateFile(file);
				_generationEnvironment.Remove(block.Start, block.Length);

				list.Add(file);
			}
		}

		projectSyncAction.EndInvoke(projectSyncAction.BeginInvoke(list, null, null));
		this.CleanUpTemplatePlaceholders();
		var items = VSHelper.GetOutputFilesAsProjectItems(this.dte, list);
		this.WriteVsProperties(items, list);

		if (this.IsAutoIndentEnabled == true && split == true)
		{
			this.FormatProjectItems(items);
		}

		this.WriteLog(list);

		return list;
	}

	private void FormatProjectItems(IEnumerable<EnvDTE.ProjectItem> items)
	{
		foreach (var item in items)
		{
			this._textTransformation.WriteLine(
			VSHelper.ExecuteVsCommand(this.dte, item, "Edit.FormatDocument")); //, "Edit.RemoveAndSort"));
			this._textTransformation.WriteLine("//-> " + item.Name);
		}
	}

	private void WriteVsProperties(IEnumerable<EnvDTE.ProjectItem> items, IEnumerable<OutputFile> outputFiles)
	{
		foreach (var file in outputFiles)
		{
			var item = items.Where(p => p.Name == Path.GetFileName(file.FileName)).FirstOrDefault();
			if (item == null) continue;

			if (String.IsNullOrEmpty(file.FileProperties.CustomTool) == false)
			{
				VSHelper.SetPropertyValue(item, "CustomTool", file.FileProperties.CustomTool);
			}

			if (String.IsNullOrEmpty(file.FileProperties.BuildActionString) == false)
			{
				VSHelper.SetPropertyValue(item, "ItemType", file.FileProperties.BuildActionString);
			}
		}
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
	private void WriteLog(IEnumerable<OutputFile> list)
	{
		this._textTransformation.WriteLine("// Generated helper templates");
		foreach (var item in templatePlaceholderList)
		{
			this._textTransformation.WriteLine("// " + this.GetDirectorySolutionRelative(item));
		}

		this._textTransformation.WriteLine("// Generated items");
		foreach (var item in list)
		{
			this._textTransformation.WriteLine("// " + this.GetDirectorySolutionRelative(item.FileName));
		}
	}

	/// <summary>
	/// Removes old template placeholders from the solution.
	/// </summary>
	private void CleanUpTemplatePlaceholders()
	{
		string[] activeTemplateFullNames = this.templatePlaceholderList.ToArray();
		string[] allHelperTemplateFullNames = VSHelper.GetAllSolutionItems(this.dte)
			.Where(p => p.Name == VSHelper.GetTemplatePlaceholderName(this.templateProjectItem))
			.Select(p => VSHelper.GetProjectItemFullPath(p))
			.ToArray();

		var delta = allHelperTemplateFullNames.Except(activeTemplateFullNames).ToArray();

		var dirtyHelperTemplates = VSHelper.GetAllSolutionItems(this.dte)
			.Where(p => delta.Contains(VSHelper.GetProjectItemFullPath(p)));

		foreach (ProjectItem item in dirtyHelperTemplates)
		{
			if (item.ProjectItems != null)
			{
				foreach (ProjectItem subItem in item.ProjectItems)
				{
					subItem.Remove();
				}
			}

			item.Remove();
		}
	}

	/// <summary>
	/// Gets a list of helper templates from the log.
	/// </summary>
	/// <returns>List of generated helper templates.</returns>
	private string[] GetPreviousTemplatePlaceholdersFromLog()
	{
		string path = Path.GetDirectoryName(this._textTransformation.Host.ResolvePath(this._textTransformation.Host.TemplateFile));
		string file1 = Path.GetFileNameWithoutExtension(this._textTransformation.Host.TemplateFile) + ".txt";
		string contentPrevious = File.ReadAllText(Path.Combine(path, file1));

		var result = contentPrevious
				.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).First())
				.Select(x => Regex.Replace(x, "//", String.Empty).Trim())
				.Where(x => x.EndsWith(VSHelper.GetTemplatePlaceholderName(this.templateProjectItem)))
				.ToArray();

		return result;
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

	private void ProjectSync(EnvDTE.ProjectItem templateProjectItem, IEnumerable<OutputFile> keepFileNames)
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

		this.templatePlaceholderList.Clear();

		foreach (var item in groupedFileNames)
		{
			EnvDTE.ProjectItem pi = VSHelper.FindProjectItem(templateProjectItem.DTE, item.FirstItem, templateProjectItem);

			if (pi != null)
			{
				ProjectItemSyncPart(pi, item.OutputFiles);
			}
			else
			{
				EnvDTE.Project prj = VSHelper.GetProject(dte, item.FirstItem.ProjectName);
				ProjectSyncPart(prj, item.OutputFiles);
			}
		}

		// clean up
		bool hasDefaultItems = groupedFileNames.Where(f => String.IsNullOrEmpty(f.ProjectName) && String.IsNullOrEmpty(f.FolderName)).Count() > 0;
		if (hasDefaultItems == false)
		{
			ProjectItemSyncPart(templateProjectItem, new List<OutputFile>());
		}
	}

	private static void ProjectSyncPart(EnvDTE.Project project, IEnumerable<OutputFile> keepFileNames)
	{
		var keepFileNameSet = new HashSet<OutputFile>(keepFileNames);

		var projectFiles = new Dictionary<string, EnvDTE.ProjectItem>();
		//var originalOutput = Path.GetFileNameWithoutExtension(project.FileName);

		foreach (EnvDTE.ProjectItem projectItem in project.ProjectItems)
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

	private static void ProjectItemSyncPart(EnvDTE.ProjectItem templateProjectItem, IEnumerable<OutputFile> keepFileNames)
	{
		var keepFileNameSet = new HashSet<OutputFile>(keepFileNames);
		var projectFiles = new Dictionary<string, EnvDTE.ProjectItem>();
		var originalOutput = Path.GetFileNameWithoutExtension(templateProjectItem.FileNames[0]);

		foreach (EnvDTE.ProjectItem projectItem in templateProjectItem.ProjectItems)
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
	public static string ExecuteVsCommand(EnvDTE.DTE dte, EnvDTE.ProjectItem item, params string[] command)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}

		string error = String.Empty;

		try
		{
			EnvDTE.Window window = item.Open();
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
	public static void SetPropertyValue(EnvDTE.ProjectItem item, string propertyName, object value)
	{
		EnvDTE.Property property = item.Properties.Item(propertyName);
		if (property == null)
		{
			throw new ArgumentException(String.Format("The property {0} was not found.", propertyName));
		}
		else
		{
			property.Value = value;
		}
	}

	public static IEnumerable<ProjectItem> GetOutputFilesAsProjectItems(EnvDTE.DTE dte, IEnumerable<OutputFile> outputFiles)
	{
		var fileNames = (from o in outputFiles
							  select Path.GetFileName(o.FileName))
							.ToArray();

		return VSHelper.GetAllSolutionItems(dte).Where(f => fileNames.Contains(f.Name));
	}

	public static string GetOutputPath(EnvDTE.DTE dte, Block block, string defaultPath)
	{
		if (String.IsNullOrEmpty(block.ProjectName) == true && String.IsNullOrEmpty(block.FolderName) == true)
		{
			return defaultPath;
		}

		EnvDTE.Project prj = null;
		EnvDTE.ProjectItem item = null;

		if (String.IsNullOrEmpty(block.ProjectName) == false)
		{
			prj = GetProject(dte, block.ProjectName);
		}

		if (String.IsNullOrEmpty(block.FolderName) == true && prj != null)
		{
			return Path.GetDirectoryName(prj.FullName);
		}
		else if (prj != null && String.IsNullOrEmpty(block.FolderName) == false)
		{
			item = GetAllProjectItemsRecursive(prj.ProjectItems).Where(i => i.Name == block.FolderName).First();
		}
		else if (String.IsNullOrEmpty(block.FolderName) == false)
		{
			item = GetAllProjectItemsRecursive(dte.ActiveDocument.ProjectItem.ContainingProject.ProjectItems)
					.Where(i => i.Name == block.FolderName).First();
		}

		if (item != null)
		{
			return GetProjectItemFullPath(item);
		}

		return defaultPath;
	}

	public static string GetTemplatePlaceholderName(EnvDTE.ProjectItem item)
	{
		return String.Format("{0}.txt4", Path.GetFileNameWithoutExtension(item.Name));
	}

	public static EnvDTE.ProjectItem FindProjectItem(EnvDTE.DTE dte, OutputFile file, EnvDTE.ProjectItem defaultItem)
	{
		if (String.IsNullOrEmpty(file.ProjectName) == true && String.IsNullOrEmpty(file.FolderName) == true)
		{
			return defaultItem;
		}

		string templatePlaceholder = GetTemplatePlaceholderName(defaultItem);
		string itemPath = Path.GetDirectoryName(file.FileName);
		string fullName = Path.Combine(itemPath, templatePlaceholder);
		EnvDTE.Project prj = null;
		EnvDTE.ProjectItem item = null;

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

	private static EnvDTE.ProjectItem FindProjectItem(EnvDTE.ProjectItems items, string fullName, bool canCreateIfNotExists)
	{
		EnvDTE.ProjectItem item = (from i in items.Cast<EnvDTE.ProjectItem>()
											where i.Name == Path.GetFileName(fullName)
											select i).FirstOrDefault();
		if (item == null)
		{
			File.CreateText(fullName);
			item = items.AddFromFile(fullName);
		}

		return item;
	}

	public static EnvDTE.Project GetProject(EnvDTE.DTE dte, string projectName)
	{
		return GetAllProjects(dte).Where(p => p.Name == projectName).First();
	}

	public static IEnumerable<EnvDTE.Project> GetAllProjects(EnvDTE.DTE dte)
	{
		List<EnvDTE.Project> projectList = new List<EnvDTE.Project>();

		var folders = dte.Solution.Projects.Cast<EnvDTE.Project>().Where(p => p.Kind == EnvDTE80.ProjectKinds.vsProjectKindSolutionFolder);

		foreach (EnvDTE.Project folder in folders)
		{
			if (folder.ProjectItems == null) continue;

			foreach (EnvDTE.ProjectItem item in folder.ProjectItems)
			{
				if (item.Object is EnvDTE.Project)
					projectList.Add(item.Object as EnvDTE.Project);
			}
		}

		var projects = dte.Solution.Projects.Cast<EnvDTE.Project>().Where(p => p.Kind != EnvDTE80.ProjectKinds.vsProjectKindSolutionFolder);

		if (projects.Count() > 0)
			projectList.AddRange(projects);

		return projectList;
	}

	public static EnvDTE.ProjectItem GetProjectItemWithName(EnvDTE.ProjectItems items, string itemName)
	{
		return GetAllProjectItemsRecursive(items).Cast<ProjectItem>().Where(i => i.Name == itemName).First();
	}

	public static string GetProjectItemFullPath(EnvDTE.ProjectItem item)
	{
		return item.Properties.Item("FullPath").Value.ToString();
	}

	public static IEnumerable<EnvDTE.ProjectItem> GetAllSolutionItems(EnvDTE.DTE dte)
	{
		List<EnvDTE.ProjectItem> itemList = new List<EnvDTE.ProjectItem>();

		foreach (Project item in GetAllProjects(dte))
		{
			if (item == null || item.ProjectItems == null) continue;

			itemList.AddRange(GetAllProjectItemsRecursive(item.ProjectItems));
		}

		return itemList;
	}

	public static IEnumerable<EnvDTE.ProjectItem> GetAllProjectItemsRecursive(EnvDTE.ProjectItems projectItems)
	{
		foreach (EnvDTE.ProjectItem projectItem in projectItems)
		{
			if (projectItem.ProjectItems == null) continue;

			foreach (EnvDTE.ProjectItem subItem in GetAllProjectItemsRecursive(projectItem.ProjectItems))
			{
				yield return subItem;
			}

			yield return projectItem;
		}
	}

	public static List<CodeClass> FindClasses(string projectName, string nameSpace, ITextTemplatingEngineHost host)
	{

		List<CodeClass> result = new List<CodeClass>();
		Project project = null;

		var env = (DTE)((IServiceProvider)host).GetService(typeof(EnvDTE.DTE));

		foreach (Project p in env.Solution.Projects)
		{
			if (p.Name == projectName)
			{
				project = p;
			}
		}

		if (project != null)
		{
			FindClasses(project.CodeModel.CodeElements, nameSpace, result);
		}

		return result;

	}


	private static void FindClasses(CodeElements elements, string searchNamespace, List<CodeClass> result)
	{

		if (elements == null) return;

		CodeElements namespaceElements = FindNamespaceClasses(searchNamespace, elements);

		if (namespaceElements != null)
		{
			foreach (CodeElement element in namespaceElements)
			{
				if (element.Kind == EnvDTE.vsCMElement.vsCMElementClass)
				{
					CodeClass c = element as CodeClass;
					if (c != null)
					{
						result.Add(c);
					}
				}
			}
		}

	}

	private static CodeElements FindNamespaceClasses(string searchNamespace, CodeElements elements)
	{

		string[] splitted = searchNamespace.Split(new string[] { "." }, 2, StringSplitOptions.None);

		foreach (CodeElement element in elements)
		{
			if (element is EnvDTE.CodeNamespace)
			{
				EnvDTE.CodeNamespace ns = element as EnvDTE.CodeNamespace;
				if (ns != null)
				{
					if (searchNamespace.Contains(ns.FullName))
					{
						if (ns.FullName == searchNamespace)
						{
							return ns.Members;
						}
						else if (splitted[1] != null)
						{
							return FindNamespaceClasses(searchNamespace, ns.Members);
						}
					}
				}
			}
		}

		return null;
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
