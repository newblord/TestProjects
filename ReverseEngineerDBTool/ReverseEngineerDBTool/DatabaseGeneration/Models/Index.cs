using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.DatabaseGeneration.Models
{
    public class Index
    {
        public string SchemaName { get; set; }
        public string IndexName { get; set; }
        public string TableName { get; set; }
        public bool IsUnique { get; set; }
        public bool IsPrimaryKey { get; set; }
        public string ColumnString { get; set; }
        public List<TableColumn> Columns { get; set; }

        public Index()
        {
            Columns = new List<TableColumn>();
        }

        public string GetParameterString()
        {
            return string.Join(", ", Columns.Select(s => s.PropertyType + " " + s.ParameterName));
        }

        public string GetWhereString()
        {
            return string.Join(" && ", Columns.Select(s => "x." + s.NameHumanCase + " == " + s.ParameterName));
        }
    }
}
