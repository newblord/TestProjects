using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.DatabaseGeneration.Settings
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
        public string EnumFolderName { get; set; } = "Enums";
        public string EnumProjectName { get; set; } = string.Empty;

        public string ContextNamespace { get; set; } = "Context";
        public string ModelNamespace { get; set; } = "Models";
        public string ModelDtoNamespace { get; set; } = "Models.DTOs";
        public string ModelInterfaceNamespace { get; set; } = "Models.Interfaces";
        public string RepositoryNamespace { get; set; } = "Repositories";
        public string RepositoryInterfaceNamespace { get; set; } = "Repositories.Interfaces";
        public string ServiceNamespace { get; set; } = "Services";
        public string ServiceInterfaceNamespace { get; set; } = "Services.Interfaces";
        public string SpecificationNamespace { get; set; } = "Specifications";
        public string ConfigurationNamespace { get; set; } = "Models.Configurations";
        public string EnumNamespace { get; set; } = "Models.Enums";
        public string UnitOfWorkNamespace
        {
            get
            {
                return $"{ContextNamespace}.UnitOfWork";
            }
        }
    }
}
