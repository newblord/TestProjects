using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class SchemaReader
	{
		private const string TableSQL = @"
			SELECT  c.TABLE_SCHEMA AS SchemaName,
			c.TABLE_NAME AS TableName,
			t.TABLE_TYPE AS TableType,
			c.ORDINAL_POSITION AS Ordinal,
			c.COLUMN_NAME AS ColumnName,
			CAST(CASE WHEN IS_NULLABLE = 'YES' THEN 1
						ELSE 0
					END AS BIT) AS IsNullable,
			DATA_TYPE AS TypeName,
			ISNULL(CHARACTER_MAXIMUM_LENGTH, 0) AS [MaxLength],
			CAST(ISNULL(NUMERIC_PRECISION, 0) AS INT) AS [Precision],
			ISNULL(COLUMN_DEFAULT, '') AS [Default],
			CAST(ISNULL(DATETIME_PRECISION, 0) AS INT) AS DateTimePrecision,
			ISNULL(NUMERIC_SCALE, 0) AS Scale,
			CAST(COLUMNPROPERTY(OBJECT_ID(QUOTENAME(c.TABLE_SCHEMA) + '.' + QUOTENAME(c.TABLE_NAME)), c.COLUMN_NAME, 'IsIdentity') AS BIT) AS IsIdentity,
			CAST(CASE WHEN COLUMNPROPERTY(OBJECT_ID(QUOTENAME(c.TABLE_SCHEMA) + '.' + QUOTENAME(c.TABLE_NAME)), c.COLUMN_NAME, 'IsIdentity') = 1 THEN 1
						WHEN COLUMNPROPERTY(OBJECT_ID(QUOTENAME(c.TABLE_SCHEMA) + '.' + QUOTENAME(c.TABLE_NAME)), c.COLUMN_NAME, 'IsComputed') = 1 THEN 1
						WHEN DATA_TYPE = 'TIMESTAMP' THEN 1
						WHEN DATA_TYPE = 'UNIQUEIDENTIFIER' AND LOWER(ISNULL(COLUMN_DEFAULT, '')) LIKE '%newsequentialid%' THEN 1
						ELSE 0
					END AS BIT) AS IsStoreGenerated,
			CAST(CASE WHEN pk.ORDINAL_POSITION IS NULL THEN 0
						ELSE 1
					END AS BIT) AS PrimaryKey,
			ISNULL(pk.ORDINAL_POSITION, 0) PrimaryKeyOrdinal,
			CAST(CASE WHEN fk.COLUMN_NAME IS NULL THEN 0
						ELSE 1
					END AS BIT) AS IsForeignKey
			FROM	 INFORMATION_SCHEMA.COLUMNS c
			LEFT OUTER JOIN (SELECT u.TABLE_SCHEMA,
											u.TABLE_NAME,
											u.COLUMN_NAME,
											u.ORDINAL_POSITION
									FROM	INFORMATION_SCHEMA.KEY_COLUMN_USAGE u
											INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
												ON u.TABLE_SCHEMA = tc.CONSTRAINT_SCHEMA
													AND u.TABLE_NAME = tc.TABLE_NAME
													AND u.CONSTRAINT_NAME = tc.CONSTRAINT_NAME
									WHERE  CONSTRAINT_TYPE = 'PRIMARY KEY') pk
				ON c.TABLE_SCHEMA = pk.TABLE_SCHEMA
					AND c.TABLE_NAME = pk.TABLE_NAME
					AND c.COLUMN_NAME = pk.COLUMN_NAME
			LEFT OUTER JOIN (SELECT DISTINCT
											u.TABLE_SCHEMA,
											u.TABLE_NAME,
											u.COLUMN_NAME
									FROM	INFORMATION_SCHEMA.KEY_COLUMN_USAGE u
											INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
												ON u.TABLE_SCHEMA = tc.CONSTRAINT_SCHEMA
													AND u.TABLE_NAME = tc.TABLE_NAME
													AND u.CONSTRAINT_NAME = tc.CONSTRAINT_NAME
									WHERE  CONSTRAINT_TYPE = 'FOREIGN KEY') fk
				ON c.TABLE_SCHEMA = fk.TABLE_SCHEMA
					AND c.TABLE_NAME = fk.TABLE_NAME
					AND c.COLUMN_NAME = fk.COLUMN_NAME
			INNER JOIN INFORMATION_SCHEMA.TABLES t
				ON c.TABLE_SCHEMA = t.TABLE_SCHEMA
					AND c.TABLE_NAME = t.TABLE_NAME
			WHERE c.TABLE_NAME NOT IN ('EdmMetadata', '__MigrationHistory')
			AND c.TABLE_NAME IN ('{TABLE_NAMES}')";

		private const string ForeignKeySQL = @"
			SELECT  FK.name AS FK_Table,
			FkCol.name AS FK_Column,
			PK.name AS PK_Table,
			PkCol.name AS PK_Column,
			OBJECT_NAME(f.object_id) AS Constraint_Name,
			SCHEMA_NAME(FK.schema_id) AS fkSchema,
			SCHEMA_NAME(PK.schema_id) AS pkSchema,
			PkCol.name AS primarykey,
			k.constraint_column_id AS ORDINAL_POSITION,
			CASE WHEN f.delete_referential_action = 1 THEN 1 ELSE 0 END as CascadeOnDelete
			FROM	 sys.objects AS PK
			INNER JOIN sys.foreign_keys AS f
				INNER JOIN sys.foreign_key_columns AS k
						ON k.constraint_object_id = f.object_id
				INNER JOIN sys.indexes AS i
						ON f.referenced_object_id = i.object_id
							AND f.key_index_id = i.index_id
				ON PK.object_id = f.referenced_object_id
			INNER JOIN sys.objects AS FK
				ON f.parent_object_id = FK.object_id
			INNER JOIN sys.columns AS PkCol
				ON f.referenced_object_id = PkCol.object_id
					AND k.referenced_column_id = PkCol.column_id
			INNER JOIN sys.columns AS FkCol
				ON f.parent_object_id = FkCol.object_id
					AND k.parent_column_id = FkCol.column_id
			ORDER BY FK_Table, FK_Column";

		private const string StoredProcedureSQL = @"
			SELECT  R.SPECIFIC_SCHEMA,
			R.SPECIFIC_NAME,
			R.ROUTINE_TYPE,
			P.ORDINAL_POSITION,
			P.PARAMETER_MODE,
			P.PARAMETER_NAME,
			P.DATA_TYPE,
			ISNULL(P.CHARACTER_MAXIMUM_LENGTH, 0) AS CHARACTER_MAXIMUM_LENGTH,
			ISNULL(P.NUMERIC_PRECISION, 0) AS NUMERIC_PRECISION,
			ISNULL(P.NUMERIC_SCALE, 0) AS NUMERIC_SCALE,
			ISNULL(P.DATETIME_PRECISION, 0) AS DATETIME_PRECISION,
			P.USER_DEFINED_TYPE_SCHEMA + '.' + P.USER_DEFINED_TYPE_NAME AS USER_DEFINED_TYPE
			FROM	 INFORMATION_SCHEMA.ROUTINES R
			LEFT OUTER JOIN INFORMATION_SCHEMA.PARAMETERS P
				ON P.SPECIFIC_SCHEMA = R.SPECIFIC_SCHEMA
					AND P.SPECIFIC_NAME = R.SPECIFIC_NAME
			WHERE	R.ROUTINE_TYPE = 'PROCEDURE'
			AND (
					P.IS_RESULT = 'NO'
					OR P.IS_RESULT IS NULL
				)
			AND R.SPECIFIC_SCHEMA + R.SPECIFIC_NAME IN (
				SELECT  SCHEMA_NAME(sp.schema_id) + sp.name
				FROM	 sys.all_objects AS sp
							LEFT OUTER JOIN sys.all_sql_modules AS sm
								ON sm.object_id = sp.object_id
				WHERE	sp.type = 'P'
							AND (CAST(CASE WHEN sp.is_ms_shipped = 1 THEN 1
												WHEN (
														SELECT major_id
														FROM	sys.extended_properties
														WHERE  major_id = sp.object_id
																AND minor_id = 0
																AND class = 1
																AND name = N'microsoft_database_tools_support'
														) IS NOT NULL THEN 1
												ELSE 0
										END AS BIT) = 0))
			AND R.SPECIFIC_NAME IN ('{SPROC_NAMES}')

			UNION ALL
			SELECT  R.SPECIFIC_SCHEMA,
			R.SPECIFIC_NAME,
			R.ROUTINE_TYPE,
			P.ORDINAL_POSITION,
			P.PARAMETER_MODE,
			P.PARAMETER_NAME,
			P.DATA_TYPE,
			ISNULL(P.CHARACTER_MAXIMUM_LENGTH, 0) AS CHARACTER_MAXIMUM_LENGTH,
			ISNULL(P.NUMERIC_PRECISION, 0) AS NUMERIC_PRECISION,
			ISNULL(P.NUMERIC_SCALE, 0) AS NUMERIC_SCALE,
			ISNULL(P.DATETIME_PRECISION, 0) AS DATETIME_PRECISION,
			P.USER_DEFINED_TYPE_SCHEMA + '.' + P.USER_DEFINED_TYPE_NAME AS USER_DEFINED_TYPE
			FROM	 INFORMATION_SCHEMA.ROUTINES R
			LEFT OUTER JOIN INFORMATION_SCHEMA.PARAMETERS P
				ON P.SPECIFIC_SCHEMA = R.SPECIFIC_SCHEMA
					AND P.SPECIFIC_NAME = R.SPECIFIC_NAME
			WHERE	R.ROUTINE_TYPE = 'FUNCTION'
			AND R.DATA_TYPE = 'TABLE'
			AND R.SPECIFIC_NAME IN ('{SPROC_NAMES}')
			ORDER BY R.SPECIFIC_SCHEMA,
			R.SPECIFIC_NAME,
			P.ORDINAL_POSITION";

		private bool IncludeQueryTraceOn9481Flag;
		public List<string> TableNames { get; set; }
		public List<string> StoredProcedureNames { get; set; }

		protected readonly DbCommand Cmd;

		public SchemaReader(DbConnection connection, DbProviderFactory factory, bool includeQueryTraceOn9481Flag)
		{
			Cmd = factory.CreateCommand();
			if (Cmd != null)
				Cmd.Connection = connection;

			IncludeQueryTraceOn9481Flag = includeQueryTraceOn9481Flag;
			TableNames = new List<string>();
			StoredProcedureNames = new List<string>();
		}

		private string IncludeQueryTraceOn9481()
		{
			if (IncludeQueryTraceOn9481Flag)
				return @"
				OPTION (QUERYTRACEON 9481)";
			return string.Empty;
		}

		private string ProcessTableSQL()
		{
			string sql = TableSQL.Replace("{TABLE_NAMES}", string.Join("', '", TableNames));
			return sql;
		}

		private string ProcessStoredProcSQL()
		{
			string sql = StoredProcedureSQL.Replace("{SPROC_NAMES}", string.Join("', '", StoredProcedureNames));
			return sql;
		}

		protected bool IsFilterExcluded(Regex filterExclude, Regex filterInclude, string name)
		{
			if (filterExclude != null && filterExclude.IsMatch(name))
				return true;
			if (filterInclude != null && !filterInclude.IsMatch(name))
				return true;
			if (name.Contains('.'))  // EF does not allow tables to contain a period character
				return true;
			return false;
		}

		public Tables ReadSchema(Regex schemaFilterExclude, Regex schemaFilterInclude, Regex tableFilterExclude, Regex tableFilterInclude, Regex columnFilterExclude, Func<Table, bool> tableFilter, bool useCamelCase, bool prependSchemaName, CommentsStyle includeComments, Func<string, string, string> tableRename, Func<Column, Table, Column> updateColumn, bool usePrivateSetterForComputedColumns)
		{
			var result = new Tables();
			if (Cmd == null)
				return result;

			Cmd.CommandText = ProcessTableSQL() + IncludeQueryTraceOn9481();
			Cmd.CommandTimeout = 600;

			using (DbDataReader rdr = Cmd.ExecuteReader())
			{
				var rxClean = new Regex("^(event|Equals|GetHashCode|GetType|ToString|repo|Save|IsNew|Insert|Update|Delete|Exists|SingleOrDefault|Single|First|FirstOrDefault|Fetch|Page|Query)$");
				var lastTable = string.Empty;
				Table table = null;
				while (rdr.Read())
				{
					string schema = rdr["SchemaName"].ToString().Trim();
					if (IsFilterExcluded(schemaFilterExclude, schemaFilterInclude, schema))
						continue;

					string tableName = rdr["TableName"].ToString().Trim();
					if (IsFilterExcluded(tableFilterExclude, tableFilterInclude, tableName))
						continue;

					if (lastTable != tableName || table == null)
					{
						// The data from the database is not sorted
						table = result.Find(x => x.Name == tableName && x.Schema == schema);
						if (table == null)
						{
							table = new Table
							{
								Name = tableName,
								Schema = schema,
								IsView = String.Compare(rdr["TableType"].ToString().Trim(), "View", StringComparison.OrdinalIgnoreCase) == 0,

								// Will be set later
								HasForeignKey = false,
								HasNullableColumns = false
							};

							tableName = tableRename(tableName, schema);
							if (IsFilterExcluded(tableFilterExclude, null, tableName)) // Retest exclusion filter after table rename
								continue;

							// Handle table names with underscores - singularise just the last word
							table.ClassName = Inflector.MakeSingular(ReversePocoCore.CleanUp(tableName));
							var titleCase = (useCamelCase ? Inflector.ToTitleCase(table.ClassName) : table.ClassName).Replace(" ", "").Replace("$", "").Replace(".", "");
							table.NameHumanCase = titleCase;


							if ((string.Compare(table.Schema, "dbo", StringComparison.OrdinalIgnoreCase) != 0) && prependSchemaName)
								table.NameHumanCase = table.Schema + "_" + table.NameHumanCase;

							// Check for table or C# name clashes
							if (ReversePocoCore.ReservedKeywords.Contains(table.NameHumanCase) ||
								(useCamelCase && result.Find(x => x.NameHumanCase == table.NameHumanCase) != null))
							{
								table.NameHumanCase += "1";
							}

							if (!tableFilter(table))
								continue;

							result.Add(table);
						}
					}

					var col = CreateColumn(rdr, rxClean, table, useCamelCase, columnFilterExclude, updateColumn);
					if (col != null)
						table.Columns.Add(col);
				}
			}

			// Check for property name clashes in columns
			foreach (Column c in result.SelectMany(tbl => tbl.Columns.Where(c => tbl.Columns.FindAll(x => x.NameHumanCase == c.NameHumanCase).Count > 1)))
			{
				int n = 1;
				var original = c.NameHumanCase;
				c.NameHumanCase = original + n++;

				// Check if the above resolved the name clash, if not, use next value
				while (c.ParentTable.Columns.Count(c2 => c2.NameHumanCase == c.NameHumanCase) > 1)
					c.NameHumanCase = original + n++;
			}

			foreach (Table tbl in result)
			{
				tbl.Columns.ForEach(x => x.SetupEntityAndConfig(includeComments, usePrivateSetterForComputedColumns));
			}

			return result;
		}

		public List<ForeignKey> ReadForeignKeys(Func<string, string, string> tableRename, Func<ForeignKey, ForeignKey> foreignKeyFilter)
		{
			var fkList = new List<ForeignKey>();
			if (Cmd == null)
				return fkList;

			Cmd.CommandText = ForeignKeySQL + IncludeQueryTraceOn9481();
			Cmd.CommandTimeout = 600;

			using (DbDataReader rdr = Cmd.ExecuteReader())
			{
				while (rdr.Read())
				{
					string fkTableName = rdr["FK_Table"].ToString();
					string fkSchema = rdr["fkSchema"].ToString();
					string pkTableName = rdr["PK_Table"].ToString();
					string pkSchema = rdr["pkSchema"].ToString();
					string fkColumn = rdr["FK_Column"].ToString();
					string pkColumn = rdr["PK_Column"].ToString();
					string constraintName = rdr["Constraint_Name"].ToString();
					int ordinal = (int)rdr["ORDINAL_POSITION"];
					bool cascadeOnDelete = ((int)rdr["CascadeOnDelete"]) == 1;

					string fkTableNameFiltered = tableRename(fkTableName, fkSchema);
					string pkTableNameFiltered = tableRename(pkTableName, pkSchema);

					var fk = new ForeignKey(fkTableName, fkSchema, pkTableName, pkSchema, fkColumn, pkColumn,
							constraintName, fkTableNameFiltered, pkTableNameFiltered, ordinal, cascadeOnDelete);

					var filteredFk = foreignKeyFilter(fk);
					if (filteredFk != null)
						fkList.Add(filteredFk);
				}
			}

			return fkList;
		}

		public List<StoredProcedure> ReadStoredProcs(Regex schemaFilterExclude, Regex storedProcedureFilterExclude, bool useCamelCase, bool prependSchemaName, Func<string, string, string> StoredProcedureRename)
		{
			var result = new List<StoredProcedure>();
			if (Cmd == null)
				return result;

			Cmd.CommandText = ProcessStoredProcSQL() + IncludeQueryTraceOn9481();
			Cmd.CommandTimeout = 600;

			using (DbDataReader rdr = Cmd.ExecuteReader())
			{
				var lastSp = string.Empty;
				StoredProcedure sp = null;
				while (rdr.Read())
				{
					string spType = rdr["ROUTINE_TYPE"].ToString().Trim().ToUpper();

					string schema = rdr["SPECIFIC_SCHEMA"].ToString().Trim();
					if (schemaFilterExclude != null && schemaFilterExclude.IsMatch(schema))
						continue;

					string spName = rdr["SPECIFIC_NAME"].ToString().Trim();

					var fullname = schema + "." + spName;

					if (storedProcedureFilterExclude != null && (storedProcedureFilterExclude.IsMatch(spName) || storedProcedureFilterExclude.IsMatch(fullname)))
						continue;

					if (lastSp != fullname || sp == null)
					{
						lastSp = fullname;
						sp = new StoredProcedure
						{
							Name = spName,
							NameHumanCase = (useCamelCase ? Inflector.ToTitleCase(spName) : spName).Replace(" ", "").Replace("$", ""),
							Schema = schema
						};
						if ((string.Compare(schema, "dbo", StringComparison.OrdinalIgnoreCase) != 0) && prependSchemaName)
							sp.NameHumanCase = schema + "_" + sp.NameHumanCase;

						sp.NameHumanCase = StoredProcedureRename(sp.NameHumanCase, schema);

						if (storedProcedureFilterExclude != null && storedProcedureFilterExclude.IsMatch(sp.NameHumanCase))
							continue;

						result.Add(sp);
					}

					if (rdr["DATA_TYPE"] != null && rdr["DATA_TYPE"] != DBNull.Value)
					{
						string typename = rdr["DATA_TYPE"].ToString().Trim().ToLower();
						var scale = (int)rdr["NUMERIC_SCALE"];
						var precision = (int)((byte)rdr["NUMERIC_PRECISION"]);
						var parameterMode = rdr["PARAMETER_MODE"].ToString().Trim().ToUpper();

						var param = new StoredProcedureParameter
						{
							Ordinal = (int)rdr["ORDINAL_POSITION"],
							Mode = (parameterMode == "IN") ? StoredProcedureParameterMode.In : StoredProcedureParameterMode.InOut,
							Name = rdr["PARAMETER_NAME"].ToString().Trim(),
							SqlDbType = GetSqlDbType(typename, scale, precision),
							PropertyType = GetPropertyType(typename, scale, precision),
							DateTimePrecision = (Int16)rdr["DATETIME_PRECISION"],
							MaxLength = (int)rdr["CHARACTER_MAXIMUM_LENGTH"],
							Precision = precision,
							Scale = scale,
							UserDefinedTypeName = rdr["USER_DEFINED_TYPE"].ToString().Trim()
						};

						var clean = ReversePocoCore.CleanUp(param.Name.Replace("@", ""));
						param.NameHumanCase =
							Inflector.MakeInitialLower(
								(useCamelCase ? Inflector.ToTitleCase(clean) : clean).Replace(" ", ""));

						if (ReversePocoCore.ReservedKeywords.Contains(param.NameHumanCase))
							param.NameHumanCase = "@" + param.NameHumanCase;

						sp.Parameters.Add(param);
					}
				}
			}
			return result;
		}

		public void ReadStoredProcReturnObject(SqlConnection sqlConnection, StoredProcedure proc)
		{
			try
			{
				var sb = new StringBuilder();
				sb.AppendLine();
				sb.AppendLine("SET FMTONLY OFF; SET FMTONLY ON;");

				foreach (var param in proc.Parameters)
					sb.AppendLine(String.Format("DECLARE {0} {1};", param.Name, param.SqlDbType == "Structured" ? param.UserDefinedTypeName : param.SqlDbType));

				sb.Append(String.Format("exec [{0}].[{1}] ", proc.Schema, proc.Name));
				foreach (var param in proc.Parameters)
					sb.Append(String.Format("{0}, ", param.Name));

				if (proc.Parameters.Count > 0)
					sb.Length -= 2;

				sb.AppendLine(";");

				sb.AppendLine("SET FMTONLY OFF; SET FMTONLY OFF;");

				var ds = new DataSet();
				using (var sqlAdapter = new SqlDataAdapter(sb.ToString(), sqlConnection))
				{
					if (sqlConnection.State != ConnectionState.Open)
						sqlConnection.Open();
					sqlAdapter.SelectCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo);
					sqlConnection.Close();
					sqlAdapter.FillSchema(ds, SchemaType.Source, "MyTable");
				}

				// Tidy up parameters
				foreach (var p in proc.Parameters)
					p.NameHumanCase = Regex.Replace(p.NameHumanCase, @"[^A-Za-z0-9@\s]*", "");

				for (var count = 0; count < ds.Tables.Count; count++)
				{
					proc.ReturnModels.Add(ds.Tables[count].Columns.Cast<DataColumn>().ToList());
				}
			}
			catch (Exception)
			{
				// Stored procedure does not have a return type
			}
		}

		public void ProcessForeignKeys(List<ForeignKey> fkList, Tables tables, bool useCamelCase, bool prependSchemaName, string collectionType, bool checkForFkNameClashes, CommentsStyle includeComments, Func<string, string, short, string> ForeignKeyName)
		{
			var constraints = fkList.Select(x => x.FkSchema + "." + x.ConstraintName).Distinct();
			foreach (var constraint in constraints)
			{
				var foreignKeys = fkList
						.Where(x => string.Format("{0}.{1}", x.FkSchema, x.ConstraintName).Equals(constraint, StringComparison.InvariantCultureIgnoreCase))
						.ToList();

				var foreignKey = foreignKeys.First();

				Table fkTable = tables.GetTable(foreignKey.FkTableName, foreignKey.FkSchema);
				if (fkTable == null || fkTable.IsMapping || !fkTable.HasForeignKey)
					continue;

				Table pkTable = tables.GetTable(foreignKey.PkTableName, foreignKey.PkSchema);
				if (pkTable == null || pkTable.IsMapping)
					continue;

				var fkCols = foreignKeys.Select(x => new
				{
					fkOrdinal = x.Ordinal,
					col = fkTable.Columns.Find(n => string.Equals(n.Name, x.FkColumn, StringComparison.InvariantCultureIgnoreCase))
				})
					.Where(x => x != null)
					.ToList();

				if (!fkCols.Any())
					continue;

				var pkCols = foreignKeys.Select(x => pkTable.Columns.Find(n => string.Equals(n.Name, x.PkColumn, StringComparison.InvariantCultureIgnoreCase)))
												.Where(x => x != null && x.IsPrimaryKey)
												.OrderBy(o => o.Ordinal)
												.ToList();

				if (!pkCols.Any())
					continue;

				var fkCol = fkCols.First();
				var pkCol = pkCols.First();

				var relationship = ReversePocoCore.CalcRelationship(pkTable, fkTable, fkCols.OrderBy(o => o.fkOrdinal).Select(c => c.col).ToList(), pkCols);
				if (relationship == Relationship.DoNotUse)
					continue;

				string pkTableHumanCase = foreignKey.PkTableHumanCase(useCamelCase, prependSchemaName);
				string pkPropName = fkTable.GetUniqueColumnName(pkTableHumanCase, foreignKey, useCamelCase, checkForFkNameClashes, true, ForeignKeyName);
				bool fkMakePropNameSingular = (relationship == Relationship.OneToOne);
				string fkPropName = pkTable.GetUniqueColumnName(fkTable.NameHumanCase, foreignKey, useCamelCase, checkForFkNameClashes, fkMakePropNameSingular, ForeignKeyName);

				fkCol.col.EntityFk.Add(string.Format("public virtual {0} {1} {2}{3}", pkTableHumanCase, pkPropName, "{ get; set; }", includeComments != CommentsStyle.None ? " // " + foreignKey.ConstraintName : string.Empty));

				string manyToManyMapping, mapKey;
				if (foreignKeys.Count > 1)
				{
					var cols = fkCols.OrderBy(o => o.fkOrdinal).Distinct().ToList();
					manyToManyMapping = string.Format("c => new {{ {0} }}", string.Join(", ", cols.Select(x => "c." + x.col.NameHumanCase).ToArray()));
					mapKey = string.Format("{0}", string.Join(",", cols.Select(x => "\"" + x.col.Name + "\"").ToArray()));
				}
				else
				{
					manyToManyMapping = string.Format("c => c.{0}", fkCol.col.NameHumanCase);
					mapKey = string.Format("\"{0}\"", fkCol.col.Name);
				}

				fkCol.col.ConfigFk.Add(string.Format("{0};{1}", GetRelationship(relationship, fkCol.col, pkCol, pkPropName, fkPropName, manyToManyMapping, mapKey, foreignKey.CascadeOnDelete), includeComments != CommentsStyle.None ? " // " + foreignKey.ConstraintName : string.Empty));
				pkTable.AddReverseNavigation(relationship, pkTableHumanCase, fkTable, fkPropName, string.Format("{0}.{1}", fkTable.Name, foreignKey.ConstraintName), collectionType, includeComments);
			}
		}

		public void IdentifyForeignKeys(List<ForeignKey> fkList, Tables tables)
		{
			foreach (var foreignKey in fkList)
			{
				Table fkTable = tables.GetTable(foreignKey.FkTableName, foreignKey.FkSchema);
				if (fkTable == null)
					continue;   // Could be filtered out

				Table pkTable = tables.GetTable(foreignKey.PkTableName, foreignKey.PkSchema);
				if (pkTable == null)
					continue;   // Could be filtered out

				Column fkCol = fkTable.Columns.Find(n => string.Equals(n.Name, foreignKey.FkColumn, StringComparison.InvariantCultureIgnoreCase));
				if (fkCol == null)
					continue;   // Could not find fk column

				Column pkCol = pkTable.Columns.Find(n => string.Equals(n.Name, foreignKey.PkColumn, StringComparison.InvariantCultureIgnoreCase));
				if (pkCol == null)
					continue;   // Could not find pk column

				fkTable.HasForeignKey = true;
			}
		}

		private static string GetRelationship(Relationship relationship, Column fkCol, Column pkCol, string pkPropName, string fkPropName, string manyToManyMapping, string mapKey, bool cascadeOnDelete)
		{
			return string.Format("Has{0}(a => a.{1}){2}{3}",
				GetHasMethod(relationship, fkCol, pkCol),
				pkPropName,
				GetWithMethod(relationship, fkCol, fkPropName, manyToManyMapping, mapKey),
				cascadeOnDelete ? string.Empty : ".WillCascadeOnDelete(false)");
		}

		// HasOptional
		// HasRequired
		// HasMany
		private static string GetHasMethod(Relationship relationship, Column fkCol, Column pkCol)
		{
			bool withMany = false;
			switch (relationship)
			{
				case Relationship.ManyToOne:
				case Relationship.ManyToMany:
					withMany = true;
					break;
			}

			if (withMany || pkCol.IsPrimaryKey)
				return fkCol.IsNullable ? "Optional" : "Required";

			return "Many";
		}

		// WithOptional
		// WithRequired
		// WithMany
		// WithRequiredPrincipal
		// WithRequiredDependent
		private static string GetWithMethod(Relationship relationship, Column fkCol, string fkPropName, string manyToManyMapping, string mapKey)
		{
			switch (relationship)
			{
				case Relationship.OneToOne:
					return string.Format(".WithOptional(b => b.{0})", fkPropName);

				case Relationship.OneToMany:
					return string.Format(".WithRequiredDependent(b => b.{0})", fkPropName);

				case Relationship.ManyToOne:
					if (!fkCol.Hidden)
						return string.Format(".WithMany(b => b.{0}).HasForeignKey({1})", fkPropName, manyToManyMapping);   // Foreign Key Association
					return string.Format(".WithMany(b => b.{0}).Map(c => c.MapKey({1}))", fkPropName, mapKey);  // Independent Association

				case Relationship.ManyToMany:
					return string.Format(".WithMany(b => b.{0}).HasForeignKey({1})", fkPropName, manyToManyMapping);

				default:
					throw new ArgumentOutOfRangeException("relationship");
			}
		}

		private Column CreateColumn(IDataRecord rdr, Regex rxClean, Table table, bool useCamelCase, Regex columnFilterExclude, Func<Column, Table, Column> updateColumn)
		{
			if (rdr == null)
				throw new ArgumentNullException("rdr");

			string typename = rdr["TypeName"].ToString().Trim().ToLower();
			var scale = (int)rdr["Scale"];
			var precision = (int)rdr["Precision"];

			var col = new Column
			{
				Name = rdr["ColumnName"].ToString().Trim(),
				SqlPropertyType = typename,
				PropertyType = GetPropertyType(typename, scale, precision),
				MaxLength = (int)rdr["MaxLength"],
				Precision = precision,
				Default = rdr["Default"].ToString().Trim(),
				DateTimePrecision = (int)rdr["DateTimePrecision"],
				Scale = scale,
				Ordinal = (int)rdr["Ordinal"],
				IsIdentity = rdr["IsIdentity"].ToString().Trim().ToLower() == "true",
				IsNullable = rdr["IsNullable"].ToString().Trim().ToLower() == "true",
				IsStoreGenerated = rdr["IsStoreGenerated"].ToString().Trim().ToLower() == "true",
				IsPrimaryKey = rdr["PrimaryKey"].ToString().Trim().ToLower() == "true",
				PrimaryKeyOrdinal = (int)rdr["PrimaryKeyOrdinal"],
				IsForeignKey = rdr["IsForeignKey"].ToString().Trim().ToLower() == "true",
				ParentTable = table
			};

			if (col.MaxLength == -1 && col.SqlPropertyType.EndsWith("varchar", StringComparison.InvariantCultureIgnoreCase))
				col.SqlPropertyType += "(max)";

			if (col.IsPrimaryKey && !col.IsIdentity && col.IsStoreGenerated && typename == "uniqueidentifier")
			{
				col.IsStoreGenerated = false;
				col.IsIdentity = true;
			}

			var fullName = string.Format("{0}.{1}.{2}", table.Schema, table.Name, col.Name);
			if (columnFilterExclude != null && !col.IsPrimaryKey && (columnFilterExclude.IsMatch(col.Name) || columnFilterExclude.IsMatch(fullName)))
				col.Hidden = true;

			col.IsFixedLength = (typename == "char" || typename == "nchar");
			col.IsUnicode = !(typename == "char" || typename == "varchar" || typename == "text");
			col.IsMaxLength = (typename == "ntext");

			col.IsRowVersion = col.IsStoreGenerated && !col.IsNullable && typename == "timestamp";
			if (col.IsRowVersion)
				col.MaxLength = 8;

			if (typename == "hierarchyid")
				col.MaxLength = 0;

			col.CleanUpDefault();
			col.NameHumanCase = ReversePocoCore.CleanUp(col.Name);
			col.NameHumanCase = rxClean.Replace(col.NameHumanCase, "_$1");

			if (ReversePocoCore.ReservedKeywords.Contains(col.NameHumanCase))
				col.NameHumanCase = "@" + col.NameHumanCase;

			var titleCase = (useCamelCase ? Inflector.ToTitleCase(col.NameHumanCase) : col.NameHumanCase).Replace(" ", "");
			if (titleCase != string.Empty)
				col.NameHumanCase = titleCase;

			// Make sure property name doesn't clash with class name
			if (col.NameHumanCase == table.NameHumanCase)
				col.NameHumanCase = col.NameHumanCase + "_";

			if (char.IsDigit(col.NameHumanCase[0]))
				col.NameHumanCase = "_" + col.NameHumanCase;

			table.HasNullableColumns = ReversePocoCore.IsNullable(col);

			col = updateColumn(col, table);

			// If PropertyType is empty, return null. Most likely ignoring a column due to legacy (such as OData not supporting spatial types)
			if (string.IsNullOrEmpty(col.PropertyType))
				return null;

			return col;
		}

		private static string GetSqlDbType(string sqlType, int scale, int precision)
		{
			string sysType = "VarChar";
			switch (sqlType)
			{
				case "hierarchyid":
					sysType = "VarChar";
					break;

				case "bigint":
					sysType = "BigInt";
					break;

				case "binary":
					sysType = "Binary";
					break;

				case "bit":
					sysType = "Bit";
					break;

				case "char":
					sysType = "Char";
					break;

				case "datetime":
					sysType = "DateTime";
					break;

				case "decimal":
					sysType = "Decimal";
					break;

				case "float":
					sysType = "Float";
					break;

				case "image":
					sysType = "Image";
					break;

				case "int":
					sysType = "Int";
					break;

				case "money":
					sysType = "Money";
					break;

				case "nchar":
					sysType = "NChar";
					break;

				case "ntext":
					sysType = "NText";
					break;

				case "nvarchar":
					sysType = "NVarChar";
					break;

				case "real":
					sysType = "Real";
					break;

				case "uniqueidentifier":
					sysType = "UniqueIdentifier";
					break;

				case "smalldatetime":
					sysType = "SmallDateTime";
					break;

				case "smallint":
					sysType = "SmallInt";
					break;

				case "smallmoney":
					sysType = "SmallMoney";
					break;

				case "text":
					sysType = "Text";
					break;

				case "timestamp":
					sysType = "Timestamp";
					break;

				case "tinyint":
					sysType = "TinyInt";
					break;

				case "varbinary":
					sysType = "VarBinary";
					break;

				case "varchar":
					sysType = "VarChar";
					break;

				case "variant":
					sysType = "Variant";
					break;

				case "xml":
					sysType = "Xml";
					break;

				case "udt":
					sysType = "Udt";
					break;

				case "table type":
				case "structured":
					sysType = "Structured";
					break;

				case "date":
					sysType = "Date";
					break;

				case "time":
					sysType = "Time";
					break;

				case "datetime2":
					sysType = "DateTime2";
					break;

				case "datetimeoffset":
					sysType = "DateTimeOffset";
					break;
			}
			return sysType;
		}

		private static string GetPropertyType(string sqlType, int scale, int precision)
		{
			string sysType = "string";
			switch (sqlType)
			{
				case "hierarchyid":
					sysType = "System.Data.Entity.Hierarchy.HierarchyId";
					break;
				case "bigint":
					sysType = "long";
					break;
				case "smallint":
					sysType = "short";
					break;
				case "int":
					sysType = "int";
					break;
				case "uniqueidentifier":
					sysType = "Guid";
					break;
				case "smalldatetime":
				case "datetime":
				case "datetime2":
				case "date":
					sysType = "DateTime";
					break;
				case "datetimeoffset":
					sysType = "DateTimeOffset";
					break;
				case "table type":
					sysType = "Data.DataTable";
					break;
				case "time":
					sysType = "TimeSpan";
					break;
				case "float":
					sysType = "double";
					break;
				case "real":
					sysType = "float";
					break;
				case "numeric":
				case "smallmoney":
				case "decimal":
				case "money":
					sysType = "decimal";
					break;
				case "tinyint":
					sysType = "byte";
					break;
				case "bit":
					sysType = "bool";
					break;
				case "image":
				case "binary":
				case "varbinary":
				case "varbinary(max)":
				case "timestamp":
					sysType = "byte[]";
					break;
				case "geography":
					if (ReversePocoCore.Setting.DisableGeographyTypes)
						sysType = "";
					else
						sysType = "System.Data.Entity.Spatial.DbGeography";
					break;
				case "geometry":
					if (ReversePocoCore.Setting.DisableGeographyTypes)
						sysType = "";
					else
						sysType = "System.Data.Entity.Spatial.DbGeometry";
					break;
			}
			return sysType;
		}
	}
}
