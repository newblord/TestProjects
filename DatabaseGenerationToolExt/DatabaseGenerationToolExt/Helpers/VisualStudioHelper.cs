using EnvDTE;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DatabaseGenerationToolExt.Helpers
{
    public static class VisualStudioHelper
    {
        //private static Package Package { get; set; }

        //public static void Initialize(Package package)
        //{
        //    Package = package;
        //}

        public static DTE GetDTE()
        {
            EnvDTE.DTE dte = Microsoft.VisualStudio.Shell.Package.GetGlobalService(typeof(Microsoft.VisualStu‌​dio.Shell.Interop.SD‌​TE)) as EnvDTE.DTE;
            if (dte == null)
                throw new Exception("Unable to retrieve DTE");

            return dte;
        }

        public static Solution GetSolution()
        {
            return GetDTE().Solution;
        }

        public static Project FindProject(string projectName)
        {
            foreach (Project p in GetSolution().Projects)
            {
                if (p.Name == projectName)
                {
                    return p;
                }
            }

            return null;
        }

        public static List<ProjectItem> FindAllProjectItems(ProjectItems pis)
        {
            List<ProjectItem> results = new List<ProjectItem>();

            foreach (ProjectItem pi in pis)
            {
                if (pi.Kind == Constants.vsProjectItemKindPhysicalFolder)
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

        public static IEnumerable<Project> GetAllProjects()
        {
            foreach (var projectObj in GetSolution().Projects)
            {
                var project = projectObj as Project;
                if (project == null)
                    continue;
                if (project.Kind == Constants.vsProjectKindSolutionItems)
                    foreach (var p in RecurseSolutionFolder(project))
                        yield return p;
                else
                    yield return project;
            }
        }

        private static IEnumerable<Project> RecurseSolutionFolder(Project project)
        {
            if (project.ProjectItems == null)
                yield break;

            foreach (ProjectItem projectItem in project.ProjectItems)
            {
                var subProject = projectItem.SubProject;
                if (subProject == null)
                    continue;
                if (subProject.Kind == Constants.vsProjectKindSolutionItems)
                {
                    foreach (var p in RecurseSolutionFolder(subProject))
                        yield return p;
                }
                else
                    yield return subProject;
            }
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

        public static string GetOutputPath(EnvDTE.DTE dte, string projectName, string folderName, string defaultPath)
        {
            if (String.IsNullOrEmpty(projectName) == true && String.IsNullOrEmpty(folderName) == true)
            {
                return defaultPath;
            }

            EnvDTE.Project prj = null;
            EnvDTE.ProjectItem item = null;

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

        public static EnvDTE.ProjectItem FindProjectItem(EnvDTE.DTE dte, OutputFile file, EnvDTE.ProjectItem defaultItem)
        {
            if (String.IsNullOrEmpty(file.ProjectName) == true && String.IsNullOrEmpty(file.FolderName) == true)
            {
                return defaultItem;
            }

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

    }
}
