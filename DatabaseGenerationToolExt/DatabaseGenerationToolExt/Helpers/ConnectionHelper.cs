using EnvDTE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class ConnectionHelper
	{
		private static string[] ConfigFilenameSearchOrder = new[] { "app.config", "web.config", "app.config.transform", "web.config.transform" };

		public static List<DatabaseObjects.DatabaseConnection> FindAllConnectionStrings()
		{
			List<DatabaseObjects.DatabaseConnection> connections = new List<DatabaseObjects.DatabaseConnection>();

			var paths = GetConfigPaths();

			// Find a configuration file with the named connection string
			foreach (var path in paths)
			{

				var configFile = new ExeConfigurationFileMap { ExeConfigFilename = path };
				var config = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
				var connSection = config.ConnectionStrings;

				for (int i = 0; i < connSection.ConnectionStrings.Count; i++)
				{
					DatabaseObjects.DatabaseConnection con = new DatabaseObjects.DatabaseConnection();

					con.ConnectionStringName = connSection.ConnectionStrings[i].Name;
					con.ConnectionString = connSection.ConnectionStrings[i].ConnectionString;
					con.ProviderName = connSection.ConnectionStrings[i].ProviderName;
					con.ConfigFilePath = path;

					connections.Add(con);
				}

			}

			return connections;
		}

		private static List<string> GetConfigPaths()
		{
			var paths = new List<string>();

			// Then other projects next
			var projects = VisualStudioHelper.GetAllProjects();
			foreach (EnvDTE.Project dteProject in projects)
			{
				paths.AddRange(GetConfigPathsInProject(dteProject));
			}

			if (!paths.Any() && ConfigFilenameSearchOrder != null)
			{
				var sln = VisualStudioHelper.GetSolution();
				paths.AddRange(
					 ConfigFilenameSearchOrder
					 .Select(sln.FindProjectItem)
					 .Where(item => item != null)
					 .Select(item => item.FileNames[0]));
			}

			return paths;
		}

		private static List<string> GetConfigPathsInProject(EnvDTE.Project project)
		{
			var paths = new List<string>();
			if (ConfigFilenameSearchOrder == null || project == null)
				return paths;

			foreach (string filename in ConfigFilenameSearchOrder)
			{
				paths.AddRange(GetConfigPathsInProjectForFile(project, filename));
			}

			return paths;
		}

		private static List<string> GetConfigPathsInProjectForFile(EnvDTE.Project project, string filename)
		{
			try
			{
				if (project == null || project.Kind == EnvDTE.Constants.vsProjectKindUnmodeled)
				{
					// Project is 'unloaded'
					return new List<string>();
				}

				return (from ProjectItem item in project.ProjectItems
						  where item.Name.Equals(filename, StringComparison.InvariantCultureIgnoreCase)
						  select Path.Combine(VisualStudioHelper.GetProjectPath(project), item.Name))
						  .ToList();
			}
			catch (Exception)
			{
				return new List<string>();
			}
		}

		public static DbProviderFactory GetDbProviderFactory(string providerName)
		{
			try
			{
				return DbProviderFactories.GetFactory(providerName);
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
