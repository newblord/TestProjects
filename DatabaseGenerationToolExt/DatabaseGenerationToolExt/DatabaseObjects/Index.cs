﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class Index
	{
		public string SchemaName { get; set; }
		public string IndexName { get; set; }
		public string TableName { get; set; }
		public bool IsUnique { get; set; }
		public bool IsPrimaryKey { get; set; }
		public string ColumnString { get; set; }
		public List<Column> Columns { get; set; }

		public Index()
		{
			Columns = new List<Column>();
		}

        public static string CreateIndexParameterString(Index index)
        {
            return string.Join(", ", index.Columns.Select(s => s.PropertyType + " " + s.ParameterName));
        }

        public static string CreateIndexWhereString(Index index)
        {
            return string.Join(" && ", index.Columns.Select(s => "x." + s.NameHumanCase + " == " + s.ParameterName));
        }
    }
}
