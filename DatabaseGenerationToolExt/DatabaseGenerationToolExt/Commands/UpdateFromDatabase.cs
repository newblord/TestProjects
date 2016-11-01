//------------------------------------------------------------------------------
// <copyright file="UpdateFromDatabase.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;

namespace DatabaseGenerationToolExt.Commands
{
	/// <summary>
	/// Command handler
	/// </summary>
	internal sealed class UpdateFromDatabase
	{
		/// <summary>
		/// Command ID.
		/// </summary>
		public const int CommandId = 256;

		/// <summary>
		/// Command menu group (command set GUID).
		/// </summary>
		public static readonly Guid CommandSet = new Guid("5f433682-1f42-4f53-b712-c46977365a83");

		/// <summary>
		/// VS Package that provides this command, not null.
		/// </summary>
		private readonly Package Package;

		/// <summary>
		/// Gets the instance of the command.
		/// </summary>
		public static UpdateFromDatabase Instance
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
			Instance = new UpdateFromDatabase(package);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateFromDatabase"/> class.
		/// Adds our command handlers for menu (commands must exist in the command table file)
		/// </summary>
		/// <param name="package">Owner package, not null.</param>
		public UpdateFromDatabase(Package package)
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

				if (command != null)
				{

				}
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

		}
	}
}
