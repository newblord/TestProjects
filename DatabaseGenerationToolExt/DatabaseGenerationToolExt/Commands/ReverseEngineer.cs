//------------------------------------------------------------------------------
// <copyright file="ReverseEngineer.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using EnvDTE;
using System.Linq;
using System.Collections.Generic;
using DatabaseGenerationToolExt.Forms;
using DatabaseGenerationToolExt.Helpers;

namespace DatabaseGenerationToolExt.Commands
{
	/// <summary>
	/// Command handler
	/// </summary>
	internal sealed class ReverseEngineer
	{

		/// <summary>
		/// Command ID.
		/// </summary>
		public const int CommandId = 0x0100;

		/// <summary>
		/// Command menu group (command set GUID).
		/// </summary>
		public static readonly Guid CommandSet = new Guid("7141ad0f-37d3-4171-9641-eac3508901be");

		/// <summary>
		/// VS Package that provides this command, not null.
		/// </summary>
		private readonly Package Package;

		/// <summary>
		/// Gets the instance of the command.
		/// </summary>
		public static ReverseEngineer Instance
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the service provider from the owner package.
		/// </summary>
		private IServiceProvider ServiceProvider
		{
			get
			{
				return this.Package;
			}
		}

		/// <summary>
		/// Initializes the singleton instance of the command.
		/// </summary>
		/// <param name="package">Owner package, not null.</param>
		public static void Initialize(Package package)
		{
			Instance = new ReverseEngineer(package);
		}

		public ReverseEngineer(Package package)
		{
			if (package == null)
			{
				throw new ArgumentNullException("package");
			}

			this.Package = package;

			OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
			if (commandService != null)
			{
				var menuCommandID = new CommandID(CommandSet, CommandId);
				var menuItem = new OleMenuCommand(this.MenuItemCallback, menuCommandID);
				menuItem.BeforeQueryStatus += OnQueryStatus;
				commandService.AddCommand(menuItem);
			}
		}

		private void OnQueryStatus(object sender, EventArgs args)
		{
			try
			{
				OleMenuCommand command = (OleMenuCommand)sender;
				//DTE dte = VisualStudioHelper.GetDTE();
				//var selectedItems = dte.SelectedItems.Cast<SelectedItem>();
				//var hasContextFile = false;

				//if (command != null)
				//{
				//    if (selectedItems.Count() == 1)
				//    {
				//        SelectedItem item = selectedItems.FirstOrDefault();

				//        if (item.Project != null)
				//        {
				//            Project p = VisualStudioHelper.FindProject(item.Name);

				//            if (p != null)
				//            {
				//                IEnumerable<ProjectItem> projectItems = VisualStudioHelper.GetAllProjectItems(p.ProjectItems);

				//                IEnumerable<CodeClass> classes = projectItems.Where(x => x.FileCodeModel != null).SelectMany(x => VisualStudioHelper.FindClasses(x.FileCodeModel.CodeElements));

				//                hasContextFile = classes.SelectMany(x => x.Bases.Cast<CodeElement>().Where(y => y.FullName.Contains("DbContext"))).Count() > 0;

				//                if (hasContextFile)
				//                {
				//                    command.Visible = false;
				//                }
				//            }

				//            if (!hasContextFile)
				//            {
				//                command.Visible = true;
				//            }
				//        }
				//    }
				//    else
				//    {
				//        command.Visible = false;
				//    }
				//}

				command.Visible = true;
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// This function is the callback used to execute the command when the menu item is clicked.
		/// See the constructor to see how the menu item is associated with this function using
		/// OleMenuCommandService service and MenuCommand class.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event args.</param>
		private void MenuItemCallback(object sender, EventArgs e)
		{
			Global.InitializePackage(Package);

			using (DatabaseObjectSelector frm = new DatabaseObjectSelector())
			{
				if (!frm.IsCanceled)
				{
					frm.ShowDialog();
				}
			}
		}

	}
}
