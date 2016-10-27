using EnvDTE;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.IO;

namespace DatabaseGenerationToolExt.Helpers
{
    public class EnvDTEHelper
    {
        private Package Package { get;}

        public EnvDTEHelper(Package package)
        {
            this.Package = package;
        }

        public DTE GetDTE()
        {
            var serviceProvider = (IServiceProvider)Package;
            if (serviceProvider == null)
                throw new Exception("Package property returned unexpected value (null)");

            var dte = (DTE)serviceProvider.GetService(typeof(DTE));
            if (dte == null)
                throw new Exception("Unable to retrieve DTE");

            return dte;
        }

        public Solution GetSolution()
        {
            return GetDTE().Solution;
        }

        public Project FindProject(string projectName)
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

        public List<ProjectItem> FindAllProjectItems(ProjectItems pis)
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

        public List<CodeClass> FindClasses(CodeElements elements)
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

        public IEnumerable<Project> GetAllProjects()
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

        private IEnumerable<Project> RecurseSolutionFolder(Project project)
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

        public string GetProjectPath(Project project)
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
    }
}
