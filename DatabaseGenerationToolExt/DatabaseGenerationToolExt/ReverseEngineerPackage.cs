//------------------------------------------------------------------------------
// <copyright file="ReverseEngineerPackage.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;
using EnvDTE;
using System.Linq;
using System.Collections.Generic;

namespace DatabaseGenerationToolExt
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(ReverseEngineerPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class ReverseEngineerPackage : Package
    {
        /// <summary>
        /// ReverseEngineerPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "8778fbb2-1e06-4492-8b07-e76fdd1aa08b";

        private DTE ApplicationObject { get; set; }

        /// <summary>
        /// Command ID.
        /// </summary>
        public const int ReverseEngineerCommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid ReverseEngineerCommandSet = new Guid("7141ad0f-37d3-4171-9641-eac3508901be");

        /// <summary>
        /// Command ID.
        /// </summary>
        public const int UpdateFromDatabaseCommandId = 256;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid UpdateFromDatabaseCommandSet = new Guid("5f433682-1f42-4f53-b712-c46977365a83");

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEngineer"/> class.
        /// </summary>
        public ReverseEngineerPackage()
        {
            // Inside this method you can place any initialization code that does not require
            // any Visual Studio service because at this point the package object is created but
            // not sited yet inside Visual Studio environment. The place to do all the other
            // initialization is the Initialize method.
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (null != mcs)
            {

                ApplicationObject = (DTE)GetService(typeof(DTE));

                CommandID reverseEngineerId = new CommandID(ReverseEngineerCommandSet, ReverseEngineerCommandId);
                OleMenuCommand reverseEngineerCommand = new ReverseEngineer(reverseEngineerId);
                reverseEngineerCommand.BeforeQueryStatus += ReverseEngineer_OnQueryStatus;
                reverseEngineerCommand.Visible = true;
                mcs.AddCommand(reverseEngineerCommand);

                CommandID updateFromDatabaseId = new CommandID(UpdateFromDatabaseCommandSet, UpdateFromDatabaseCommandId);
                OleMenuCommand updateFromDatabaseCommand = new UpdateFromDatabase(updateFromDatabaseId);
                updateFromDatabaseCommand.BeforeQueryStatus += UpdateFromDatabase_OnQueryStatus;
                updateFromDatabaseCommand.Visible = true;
                mcs.AddCommand(updateFromDatabaseCommand);
            }

        }

        private void ReverseEngineer_OnQueryStatus(object sender, EventArgs args)
        {
            try
            {
                OleMenuCommand command = (OleMenuCommand)sender;

                var selectedItems = ApplicationObject.SelectedItems.Cast<SelectedItem>();
                var hasContextFile = false;

                if (command != null)
                {
                    if (selectedItems.Count() == 1)
                    {
                        SelectedItem item = selectedItems.FirstOrDefault();

                        if (item.Project != null)
                        {
                            Project p = FindProject(item.Name);

                            if (p != null)
                            {

                                List<ProjectItem> projectItems = FindAllProjectItems(p.ProjectItems);

                                List<CodeClass> classes = projectItems.Where(x => x.FileCodeModel != null).SelectMany(x => FindClasses(x.FileCodeModel.CodeElements)).ToList();

                                hasContextFile = classes.SelectMany(x => x.Bases.Cast<CodeElement>().Where(y => y.FullName.Contains("DbContext"))).Count() > 0;

                                if (hasContextFile)
                                {
                                    command.Visible = false;
                                }
                            }

                            if (!hasContextFile)
                            {
                                command.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        command.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void UpdateFromDatabase_OnQueryStatus(object sender, EventArgs args)
        {
            try
            {
                OleMenuCommand command = (OleMenuCommand)sender;

                if (command != null)
                {

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private Project FindProject(string projectName)
        {
            foreach (Project p in ApplicationObject.Solution.Projects)
            {
                if (p.Name == projectName)
                {
                    return p;
                }
            }

            return null;
        }

        private List<ProjectItem> FindAllProjectItems(ProjectItems pis)
        {
            List<ProjectItem> results = new List<ProjectItem>();

            foreach (ProjectItem pi in pis)
            {
                if (pi.Kind == EnvDTE.Constants.vsProjectItemKindPhysicalFolder)
                {
                    results.AddRange(FindAllProjectItems(pi.ProjectItems));
                }
                else
                {
                    results.Add(pi);
                }
            }

            return results;
        }

        private List<CodeClass> FindClasses(CodeElements elements)
        {
            List<CodeClass> result = new List<CodeClass>();

            foreach (CodeElement element in elements)
            {
                if (element is EnvDTE.CodeNamespace)
                {
                    if (element is EnvDTE.CodeNamespace)
                    {
                        EnvDTE.CodeNamespace ns = element as EnvDTE.CodeNamespace;

                        foreach (CodeElement ce in ns.Members)
                        {
                            if (ce.Kind == EnvDTE.vsCMElement.vsCMElementClass)
                            {
                                CodeClass c = ce as CodeClass;
                                if (c != null)
                                {
                                    result.Add(c);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        #endregion
    }
}
