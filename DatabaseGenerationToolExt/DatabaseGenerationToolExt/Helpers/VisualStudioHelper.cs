using EnvDTE;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace DatabaseGenerationToolExt.Helpers
{
    public static class VisualStudioHelper
    {
        public static DTE GetDTE()
        {
            DTE dte = Microsoft.VisualStudio.Shell.Package.GetGlobalService(typeof(Microsoft.VisualStu‌​dio.Shell.Interop.SD‌​TE)) as DTE;
            if (dte == null)
                throw new Exception("Unable to retrieve DTE");

            return dte;
        }

        /// <summary>
        /// Execute Visual Studio commands against the project item.
        /// </summary>
        /// <param name="item">The current project item.</param>
        /// <param name="command">The vs command as string.</param>
        /// <returns>An error message if the command fails.</returns>
        public static string ExecuteVsCommand(ProjectItem item, params string[] command)
        {
            DTE dte = GetDTE();

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

        public static string GetProjectPath(string projectName)
        {
            var project = FindProject(projectName);

            if (project != null)
            {
                var fullProjectName = project.FullName;

                if (string.IsNullOrWhiteSpace(fullProjectName))
                    return string.Empty;

                try
                {
                    var info = new FileInfo(fullProjectName);
                    return info.Directory == null ? string.Empty : info.Directory.FullName;
                }
                catch
                {
                    Logger.AddWarning($"// Project {fullProjectName} excluded.");
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        public static string GetProjectPath(Project project)
        {
            var fullProjectName = project.FullName;

            if (string.IsNullOrWhiteSpace(fullProjectName))
                return string.Empty;

            try
            {
                var info = new FileInfo(fullProjectName);
                return info.Directory == null ? string.Empty : info.Directory.FullName;
            }
            catch
            {
                Logger.AddWarning($"// Project {fullProjectName} excluded.");
                return string.Empty;
            }
        }

        public static string GetOutputPath(string projectName, string folderName, string defaultPath)
        {
            DTE dte = GetDTE();
            bool isProjectSpecified = !String.IsNullOrEmpty(projectName);
            bool isFolderSpecified = !String.IsNullOrEmpty(folderName);

            if (!isProjectSpecified && !isFolderSpecified)
            {
                return defaultPath;
            }

            Project prj = null;
            ProjectItem item = null;

            if (isProjectSpecified)
            {
                prj = FindProject(projectName);
            }

            if (String.IsNullOrEmpty(folderName) == true && prj != null)
            {
                return Path.GetDirectoryName(prj.FullName);
            }
            else if (prj != null && isFolderSpecified)
            {
                item = GetAllProjectItems(prj.ProjectItems).Where(i => i.FileNames[0].Replace(Path.GetDirectoryName(prj.FileName), "").Trim('\\') == folderName).First();
            }
            else if (isFolderSpecified)
            {
                item = GetAllProjectItems(dte.ActiveDocument.ProjectItem.ContainingProject.ProjectItems)
                          .Where(i => i.Name == folderName).FirstOrDefault();
            }

            if (item != null)
            {
                return GetProjectItemFullPath(item);
            }

            return defaultPath;
        }

        public static ProjectItem FindProjectItem(string projectName, string folderName)
        {
            DTE dte = GetDTE();
            bool isProjectSpecified = !String.IsNullOrEmpty(projectName);
            bool isFolderSpecified = !String.IsNullOrEmpty(folderName);

            if (!isProjectSpecified && !isFolderSpecified)
            {
                return null;
            }

            Project prj = null;
            ProjectItem item = null;

            if (isProjectSpecified)
            {
                prj = FindProject(projectName);
            }

            if (!isFolderSpecified && prj != null)
            {
                return null;
            }
            else if (prj != null && isFolderSpecified)
            {
                item = GetAllProjectItems(prj.ProjectItems).Where(i => i.FileNames[0].Replace(Path.GetDirectoryName(prj.FileName), "").Trim('\\') == folderName).First();
            }
            else if (isFolderSpecified)
            {
                item = GetAllProjectItems(dte.ActiveDocument.ProjectItem.ContainingProject.ProjectItems)
                          .Where(i => i.Name == folderName).FirstOrDefault();
            }

            if (item != null)
            {
                return item;
            }

            return null;
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

        public static ProjectItem GetProjectItemWithName(ProjectItems items, string itemName)
        {
            return GetAllProjectItems(items).Cast<ProjectItem>().Where(i => i.Name == itemName).First();
        }

        public static string GetProjectItemFullPath(ProjectItem item)
        {
            return item.Properties.Item("FullPath").Value.ToString();
        }

        public static Project FindProject(string projectName)
        {
            DTE dte = GetDTE();
            return GetAllProjects().Where(p => p.Name == projectName).FirstOrDefault();
        }

        public static IEnumerable<Project> GetAllProjects()
        {
            DTE dte = GetDTE();

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

        public static IEnumerable<ProjectItem> GetAllSolutionItems()
        {
            DTE dte = GetDTE();

            List<ProjectItem> itemList = new List<ProjectItem>();

            foreach (Project item in GetAllProjects())
            {
                if (item == null || item.ProjectItems == null) continue;

                itemList.AddRange(GetAllProjectItems(item.ProjectItems));
            }

            return itemList;
        }

        public static IEnumerable<ProjectItem> GetAllProjectItems(ProjectItems projectItems)
        {
            foreach (ProjectItem projectItem in projectItems)
            {
                if (projectItem.ProjectItems == null) continue;

                foreach (ProjectItem subItem in GetAllProjectItems(projectItem.ProjectItems))
                {
                    yield return subItem;
                }

                yield return projectItem;
            }
        }

        public static List<CodeClass> FindClasses(CodeElements elements)
        {
            List<CodeClass> result = new List<CodeClass>();

            foreach (CodeElement element in elements)
            {
                if (element is CodeNamespace)
                {
                    if (element is CodeNamespace)
                    {
                        CodeNamespace ns = element as CodeNamespace;

                        foreach (CodeElement ce in ns.Members)
                        {
                            if (ce.Kind == vsCMElement.vsCMElementClass)
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

    }

    class MessageFilter : IOleMessageFilter
    {
        //
        // Class containing the IOleMessageFilter
        // thread error-handling functions.

        // Start the filter.
        public static void Register()
        {
            IOleMessageFilter newFilter = new MessageFilter();
            IOleMessageFilter oldFilter = null;
            CoRegisterMessageFilter(newFilter, out oldFilter);
        }

        // Done with the filter, close it.
        public static void Revoke()
        {
            IOleMessageFilter oldFilter = null;
            CoRegisterMessageFilter(null, out oldFilter);
        }

        //
        // IOleMessageFilter functions.
        // Handle incoming thread requests.
        int IOleMessageFilter.HandleInComingCall(int dwCallType,
          System.IntPtr hTaskCaller, int dwTickCount, System.IntPtr
          lpInterfaceInfo)
        {
            //Return the flag SERVERCALL_ISHANDLED.
            return 0;
        }

        // Thread call was rejected, so try again.
        int IOleMessageFilter.RetryRejectedCall(System.IntPtr
          hTaskCallee, int dwTickCount, int dwRejectType)
        {
            if (dwRejectType == 2)
            // flag = SERVERCALL_RETRYLATER.
            {
                // Retry the thread call immediately if return >=0 & 
                // <100.
                return 99;
            }
            // Too busy; cancel call.
            return -1;
        }

        int IOleMessageFilter.MessagePending(System.IntPtr hTaskCallee,
          int dwTickCount, int dwPendingType)
        {
            //Return the flag PENDINGMSG_WAITDEFPROCESS.
            return 2;
        }

        // Implement the IOleMessageFilter interface.
        [DllImport("Ole32.dll")]
        private static extern int
          CoRegisterMessageFilter(IOleMessageFilter newFilter, out
          IOleMessageFilter oldFilter);
    }

    [ComImport(), Guid("00000016-0000-0000-C000-000000000046"),
    InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    interface IOleMessageFilter
    {
        [PreserveSig]
        int HandleInComingCall(
            int dwCallType,
            IntPtr hTaskCaller,
            int dwTickCount,
            IntPtr lpInterfaceInfo);

        [PreserveSig]
        int RetryRejectedCall(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwRejectType);

        [PreserveSig]
        int MessagePending(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwPendingType);
    }
}
