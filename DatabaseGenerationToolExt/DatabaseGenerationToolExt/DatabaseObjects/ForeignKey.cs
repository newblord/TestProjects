using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class ForeignKey
	{
		public string FkTableName { get; private set; }
		public string FkTableNameFiltered { get; private set; }
		public string FkSchema { get; private set; }
        public Table FKTable { get; internal set; }
		public string PkTableName { get; private set; }
		public string PkTableNameFiltered { get; private set; }
		public string PkSchema { get; private set; }
        public Table PKTable { get; internal set; }
        public string FkColumnName { get; private set; }
		public Column FKColumn { get; internal set; }
		public string PkColumnName { get; private set; }
		public Column PKColumn { get; internal set; }
		public string ConstraintName { get; private set; }
		public int Ordinal { get; private set; }
		public bool CascadeOnDelete { get; private set; }

		public ForeignKey(string fkTableName, string fkSchema, string pkTableName, string pkSchema, string fkColumn, string pkColumn, string constraintName, string fkTableNameFiltered, string pkTableNameFiltered, int ordinal, bool cascadeOnDelete)
		{
			ConstraintName = constraintName;
			PkColumnName = pkColumn;
			FkColumnName = fkColumn;
			PkSchema = pkSchema;
			PkTableName = pkTableName;
			FkSchema = fkSchema;
			FkTableName = fkTableName;
			FkTableNameFiltered = fkTableNameFiltered;
			PkTableNameFiltered = pkTableNameFiltered;
			Ordinal = ordinal;
			CascadeOnDelete = cascadeOnDelete;
		}

		public string PkTableHumanCase(bool useCamelCase, bool prependSchemaName)
		{
			string singular = Inflector.MakeSingular(PkTableNameFiltered);
			string pkTableHumanCase = (useCamelCase ? Inflector.ToTitleCase(singular) : singular).Replace(" ", "").Replace("$", "");
			if (string.Compare(PkSchema, "dbo", StringComparison.OrdinalIgnoreCase) != 0 && prependSchemaName)
				pkTableHumanCase = PkSchema + "_" + pkTableHumanCase;
			return pkTableHumanCase;
		}

        public static Relationship CalcRelationship(Table pkTable, Table fkTable, List<Column> fkCols, List<Column> pkCols)
        {
            if (fkCols.Count() == 1 && pkCols.Count() == 1)
                return CalcRelationshipSingle(pkTable, fkTable, fkCols.First(), pkCols.First());

            // This relationship has multiple composite keys

            bool fkTableAllPrimaryKeys = (fkTable.PrimaryKeys.Count() == fkCols.Count());
            bool pkTableAllPrimaryKeys = (pkTable.PrimaryKeys.Count() == pkCols.Count());
            bool fkColumnsAllPrimaryKeys = (fkCols.Count(x => x.IsPrimaryKey) == fkCols.Count());
            bool pkColumnsAllPrimaryKeys = (pkCols.Count(x => x.IsPrimaryKey) == pkCols.Count());

            // 1:1
            if (fkColumnsAllPrimaryKeys && pkColumnsAllPrimaryKeys && fkTableAllPrimaryKeys && pkTableAllPrimaryKeys)
                return Relationship.OneToOne;

            // 1:n
            if (fkColumnsAllPrimaryKeys && !pkColumnsAllPrimaryKeys && fkTableAllPrimaryKeys)
                return Relationship.OneToMany;

            // n:1
            if (!fkColumnsAllPrimaryKeys && pkColumnsAllPrimaryKeys && pkTableAllPrimaryKeys)
                return Relationship.ManyToOne;

            // n:n
            return Relationship.ManyToMany;
        }

        public static Relationship CalcRelationshipSingle(Table pkTable, Table fkTable, Column fkCol, Column pkCol)
        {
            bool fkTableSinglePrimaryKey = (fkTable.PrimaryKeys.Count() == 1);
            bool pkTableSinglePrimaryKey = (pkTable.PrimaryKeys.Count() == 1);

            // 1:1
            if (fkCol.IsPrimaryKey && pkCol.IsPrimaryKey && fkTableSinglePrimaryKey && pkTableSinglePrimaryKey)
                return Relationship.OneToOne;

            // 1:n
            if (fkCol.IsPrimaryKey && !pkCol.IsPrimaryKey && fkTableSinglePrimaryKey)
                return Relationship.OneToMany;

            // n:1
            if (!fkCol.IsPrimaryKey && pkCol.IsPrimaryKey && pkTableSinglePrimaryKey)
                return Relationship.ManyToOne;

            // n:n
            return Relationship.ManyToMany;
        }
    }
}
