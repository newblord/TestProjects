using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Settings
{
	public class ProjectSetting
	{
		
		public string ContextFolderName { get; set; } = "Context";
		public string ContextProjectName { get; set; } = string.Empty;
		public string ModelFolderName { get; set; } = "Models";
		public string ModelProjectName { get; set; } = string.Empty;
		public string ModelDtoFolderName { get; set; } = "ModelDTOs";
		public string ModelDtoProjectName { get; set; } = string.Empty;
		public string ModelInterfaceFolderName { get; set; } = "ModelInterfaces";
		public string ModelInterfaceProjectName { get; set; } = string.Empty;
		public string RepositoryFolderName { get; set; } = "Repositories";
		public string RepositoryProjectName { get; set; } = string.Empty;
		public string RepositoryInterfaceFolderName { get; set; } = "RepositoryInterfaces";
		public string RepositoryInterfaceProjectName { get; set; } = string.Empty;
		public string ServiceFolderName { get; set; } = "Services";
		public string ServiceProjectName { get; set; } = string.Empty;
		public string ServiceInterfaceFolderName { get; set; } = "ServiceInterfaces";
		public string ServiceInterfaceProjectName { get; set; } = string.Empty;
		public string SpecificationFolderName { get; set; } = "Specifications";
		public string SpecificationProjectName { get; set; } = string.Empty;
		public string ConfigurationFolderName { get; set; } = "Configurations";
		public string ConfigurationProjectName { get; set; } = string.Empty;

		public string ContextNamespace { get; set; } = "Context";
		public string ModelNamespace { get; set; } = "Models";
		public string ModelDtoNamespace { get; set; } = "Models.DTO";
		public string ModelInterfaceNamespace { get; set; } = "Models.Interface";
		public string RepositoryNamespace { get; set; } = "Repositories";
		public string RepositoryInterfaceNamespace { get; set; } = "Repositories.Interface";
		public string ServiceNamespace { get; set; } = "Services";
		public string ServiceInterfaceNamespace { get; set; } = "Services.Interface";
		public string SpecificationNamespace { get; set; } = "Specifications";
		public string ConfigurationNamespace { get; set; } = "Models.Configuration";
		public string UnitOfWorkNamespace {
			get
			{
				return $"{ContextNamespace}.UnitOfWork";
			}
		}
	}
}
