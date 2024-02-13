using EnvDTE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ReverseEngineerDBTool.Helpers
{
    public static class VisualStudioHelper
    {
        private static EnvDTE80.DTE2 DTE { get; set; }
        public static void LoadDTE()
        {
            if (DTE == null)
            {
                DTE = GetCurrentVisualStudio();

                //KillInMemoryVisualStudioInstances();

                //var solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))) + ".sln";

                //System.Type dteType = Type.GetTypeFromProgID("VisualStudio.DTE.14.0", true);
                //DTE = (EnvDTE80.DTE2)System.Activator.CreateInstance(dteType, true);

                //DTE.MainWindow.Activate();

                MessageFilter.Register();

                if (DTE == null)
                    throw new Exception("Unable to retrieve DTE");

                //DTE.Solution.Open(solutionPath);


            }
        }

        [DllImport("ole32.dll")]
        private static extern void CreateBindCtx(int reserved,
                                         out IBindCtx ppbc);
        [DllImport("ole32.dll")]
        private static extern void GetRunningObjectTable(int reserved,
          out IRunningObjectTable prot);

        public static EnvDTE80.DTE2 GetCurrentVisualStudio()
        {
            int devenvId = 0;
            var id = System.Diagnostics.Process.GetCurrentProcess().Id;
            //var query = @"SELECT Name, ProcessId, ParentProcessId FROM Win32_Process WHERE Name = 'devenv.exe'";
            var query = @"SELECT Name, ProcessId, ParentProcessId FROM Win32_Process WHERE ProcessId = " + id;
            var search = new ManagementObjectSearcher("root\\CIMV2", query);

            var results = search.Get().GetEnumerator();
            while (results.MoveNext())
            {
                var queryObj = results.Current;

                var parentId = (uint)queryObj["ParentProcessId"];
                //var processId = (uint)queryObj["ProcessId"];
                var parent = System.Diagnostics.Process.GetProcessById((int)parentId);

                if (parent.ProcessName == "devenv")
                {
                    devenvId = (int)parentId;
                    break;
                }
            }

            if (devenvId > 0)
            {
                //rot entry for visual studio running under current process.
                string rotEntry = String.Format("!VisualStudio.DTE.14.0:{0}", devenvId);
                IRunningObjectTable rot;
                GetRunningObjectTable(0, out rot);
                IEnumMoniker enumMoniker;
                rot.EnumRunning(out enumMoniker);
                enumMoniker.Reset();
                IntPtr fetched = IntPtr.Zero;
                IMoniker[] moniker = new IMoniker[1];
                while (enumMoniker.Next(1, moniker, fetched) == 0)
                {
                    IBindCtx bindCtx;
                    CreateBindCtx(0, out bindCtx);
                    string displayName;
                    moniker[0].GetDisplayName(bindCtx, null, out displayName);
                    if (displayName == rotEntry)
                    {
                        object comObject;
                        rot.GetObject(moniker[0], out comObject);
                        return (EnvDTE80.DTE2)comObject;
                    }
                }
            }
            return null;
        }

        private static void KillInMemoryVisualStudioInstances()
        {
            var id = System.Diagnostics.Process.GetCurrentProcess().Id;
            var query = @"SELECT Name, ProcessId, ParentProcessId FROM Win32_Process WHERE Name = 'devenv.exe'";
            var search = new ManagementObjectSearcher("root\\CIMV2", query);

            var results = search.Get().GetEnumerator();
            while(results.MoveNext())
            {
                var queryObj = results.Current;

                var parentId = (uint)queryObj["ParentProcessId"];
                var processId = (uint)queryObj["ProcessId"];
                var parent = System.Diagnostics.Process.GetProcessById((int)parentId);

                if(parent.ProcessName == "svchost")
                {
                    System.Diagnostics.Process.GetProcessById((int)processId).Kill();
                }
            }
        }

        public static EnvDTE80.DTE2 GetDTE()
        {
            if (DTE == null)
            {
                LoadDTE();
            }

            return DTE;
        }

        public static void ExitSolution()
        {
            if (DTE != null)
            {
                DTE.Quit();

                MessageFilter.Revoke();
            }
        }

        /// <summary>
        /// Execute Visual Studio commands against the project item.
        /// </summary>
        /// <param name="item">The current project item.</param>
        /// <param name="command">The vs command as string.</param>
        /// <returns>An error message if the command fails.</returns>
        public static string ExecuteVsCommand(ProjectItem item, params string[] command)
        {
            EnvDTE80.DTE2 dte = GetDTE();

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
            EnvDTE80.DTE2 dte = GetDTE();
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
            EnvDTE80.DTE2 dte = GetDTE();
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
            EnvDTE80.DTE2 dte = GetDTE();
            return GetAllProjects().Where(p => p.Name == projectName).FirstOrDefault();
        }

        public static IEnumerable<Project> GetAllProjects()
        {
            EnvDTE80.DTE2 dte = GetDTE();

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
            EnvDTE80.DTE2 dte = GetDTE();

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
            else
            {
                // Too busy; cancel call.
                return -1;
            }
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
