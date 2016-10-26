//------------------------------------------------------------------------------
// <copyright file="ReverseEngineer.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;

namespace DatabaseGenerationToolExt
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class ReverseEngineer : OleMenuCommand
    {

        public ProjectItem SelectedItem { get; set; }

        public ReverseEngineer(CommandID id) :
            base(new EventHandler(MenuItemCallback), id)
        {
            
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private static void MenuItemCallback(object sender, EventArgs e)
        {
            
        }
    }
}
