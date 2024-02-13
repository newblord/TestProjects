using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
    public class StoredProcedure
    {
        public string Schema { get; set; }
        public string Name { get; set; }
        public string NameHumanCase { get; set; }
        public Forms.Models.StoredProcedureData StoredProcData { get; set; }
        public List<StoredProcedureParameter> Parameters { get; set; }
        public List<List<StoredProcedureColumn>> ReturnModels { get; set; }   // A list of return models, containing a list of return columns

        public string ReturnModelName
        {
            get
            {
                return $"{NameHumanCase}ReturnModel";
            }
        }

        public string ReturnType
        {
            get
            {
                var returnModelCount = ReturnModels.Count;
                if (returnModelCount == 0)
                    return "int";

                return (returnModelCount == 1) ? $"ObjectResult<{ReturnModelName}>" : ReturnModelName;
            }
        }

        public StoredProcedure()
        {
            StoredProcData = new Forms.Models.StoredProcedureData();
            Parameters = new List<StoredProcedureParameter>();
            ReturnModels = new List<List<StoredProcedureColumn>>();
        }

        public string GetParameterString()
        {
            return string.Join(", ", Parameters.Select(s => s.PropertyType + " " + s.ParameterName));
        }

    }
}
