using DatabaseGenerationToolExt.DatabaseGeneration.Models;
using DatabaseGenerationToolExt.Forms.Models;
using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseGenerationToolExt.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            PopulateDropDownLists();
            LoadSettings();
        }

        private void BindProjectList(ComboBox cb, List<NameValueModel> list)
        {
            cb.DataSource = new BindingSource { DataSource = list };
            cb.DisplayMember = "Name";
            cb.ValueMember = "Value";
        }

        private void PopulateDropDownLists()
        {
            List<NameValueModel> values = new List<NameValueModel>();

            values.Add(new NameValueModel("None", 0));
            values.Add(new NameValueModel("In Summary Block", 1));
            values.Add(new NameValueModel("End of Field", 2));
            ddlIncludeComments.DataSource = values;
            ddlIncludeComments.DisplayMember = "Name";
            ddlIncludeComments.ValueMember = "Value";

            List<NameValueModel> projects = VisualStudioHelper.GetAllProjects().Select(x => new NameValueModel { Name = x.Name, Value = x.Name }).ToList();
            projects.Insert(0, new NameValueModel() { Name = string.Empty, Value = string.Empty });

            BindProjectList(ddlContextProject, projects);
            BindProjectList(ddlModelProject, projects);
            BindProjectList(ddlModelDtoProject, projects);
            BindProjectList(ddlModelInterfaceProject, projects);
            BindProjectList(ddlRepositoryProject, projects);
            BindProjectList(ddlRepositoryInterfaceProject, projects);
            BindProjectList(ddlServiceProject, projects);
            BindProjectList(ddlServiceInterfaceProject, projects);
            BindProjectList(ddlSpecificationProject, projects);
            BindProjectList(ddlConfigurationProject, projects);
            BindProjectList(ddlEnumProject, projects);
        }

        private void LoadSettings()
        {
            if (Global.DatabaseSetting != null)
            {
                txtDbContextName.DataBindings.Add("Text", Global.DatabaseSetting, "DatabaseContextName");
                txtContextInterfaceBaseClass.DataBindings.Add("Text", Global.DatabaseSetting, "ContextInterfaceBaseClass");
                txtContextBaseClass.DataBindings.Add("Text", Global.DatabaseSetting, "ContextBaseClass");
                txtConfigurationClassName.DataBindings.Add("Text", Global.DatabaseSetting, "ConfigurationClassName");
                ddlIncludeComments.SelectedValue = ((int)Global.DatabaseSetting.IncludeComments).ToString();

                cbxPartialClasses.DataBindings.Add("Checked", Global.DatabaseSetting, "MakeClassesPartial");
                cbxPartialInterfaces.DataBindings.Add("Checked", Global.DatabaseSetting, "MakeInterfacesPartial");
                cbxPartialContextInterface.DataBindings.Add("Checked", Global.DatabaseSetting, "MakeContextInterfacePartial");
                cbxUseDataAnnotations.DataBindings.Add("Checked", Global.DatabaseSetting, "UseDataAnnotations");
                cbxGenerateContextClass.DataBindings.Add("Checked", Global.DatabaseSetting, "GenerateContextClass");
                cbxGenerateUnitOfWorkInterface.DataBindings.Add("Checked", Global.DatabaseSetting, "GenerateUnitOfWorkInterface");
                cbxVirtualReverseNavProperty.DataBindings.Add("Checked", Global.DatabaseSetting, "VirtualReverseNavigationProperties");
                cbxUseCamelCase.DataBindings.Add("Checked", Global.DatabaseSetting, "UseCamelCase");
                cbxDisableGeographyTypes.DataBindings.Add("Checked", Global.DatabaseSetting, "DisableGeographyTypes");
                cbxNullableShortHand.DataBindings.Add("Checked", Global.DatabaseSetting, "NullableShortHand");
                cbxPrependSchema.DataBindings.Add("Checked", Global.DatabaseSetting, "PrependSchemaName");
                cbxIncludeQueryTraceOn.DataBindings.Add("Checked", Global.DatabaseSetting, "IncludeQueryTraceOn9481Flag");
            }

            if (Global.ProjectSetting != null)
            {
                ddlContextProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ContextProjectName");
                ddlModelProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ModelProjectName");
                ddlModelDtoProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ModelDtoProjectName");
                ddlModelInterfaceProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ModelInterfaceProjectName");
                ddlRepositoryProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "RepositoryProjectName");
                ddlRepositoryInterfaceProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "RepositoryInterfaceProjectName");
                ddlServiceProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ServiceProjectName");
                ddlServiceInterfaceProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ServiceInterfaceProjectName");
                ddlSpecificationProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "SpecificationProjectName");
                ddlConfigurationProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "ConfigurationProjectName");
                ddlEnumProject.DataBindings.Add("SelectedValue", Global.ProjectSetting, "EnumProjectName");

                txtContextFolder.DataBindings.Add("Text", Global.ProjectSetting, "ContextFolderName");
                txtModelFolder.DataBindings.Add("Text", Global.ProjectSetting, "ModelFolderName");
                txtModelDtoFolder.DataBindings.Add("Text", Global.ProjectSetting, "ModelDtoFolderName");
                txtModelInterfaceFolder.DataBindings.Add("Text", Global.ProjectSetting, "ModelInterfaceFolderName");
                txtRepositoryFolder.DataBindings.Add("Text", Global.ProjectSetting, "RepositoryFolderName");
                txtRepositoryInterfaceFolder.DataBindings.Add("Text", Global.ProjectSetting, "RepositoryInterfaceFolderName");
                txtServiceFolder.DataBindings.Add("Text", Global.ProjectSetting, "ServiceFolderName");
                txtServiceInterfaceFolder.DataBindings.Add("Text", Global.ProjectSetting, "ServiceInterfaceFolderName");
                txtSpecificationFolder.DataBindings.Add("Text", Global.ProjectSetting, "SpecificationFolderName");
                txtConfigurationFolder.DataBindings.Add("Text", Global.ProjectSetting, "ConfigurationFolderName");
                txtEnumFolder.DataBindings.Add("Text", Global.ProjectSetting, "EnumFolderName");

                txtContextNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ContextNamespace");
                txtModelNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ModelNamespace");
                txtModelDtoNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ModelDtoNamespace");
                txtModelInterfaceNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ModelInterfaceNamespace");
                txtRepositoryNamespace.DataBindings.Add("Text", Global.ProjectSetting, "RepositoryNamespace");
                txtRepositoryInterfaceNamespace.DataBindings.Add("Text", Global.ProjectSetting, "RepositoryInterfaceNamespace");
                txtServiceNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ServiceNamespace");
                txtServiceInterfaceNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ServiceInterfaceNamespace");
                txtSpecificationNamespace.DataBindings.Add("Text", Global.ProjectSetting, "SpecificationNamespace");
                txtConfigurationNamespace.DataBindings.Add("Text", Global.ProjectSetting, "ConfigurationNamespace");
                txtEnumNamespace.DataBindings.Add("Text", Global.ProjectSetting, "EnumNamespace");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Global.DatabaseSetting.IncludeComments = (CommentsStyle)int.Parse(ddlIncludeComments.SelectedValue.ToString());

            this.Close();
        }

    }
}
