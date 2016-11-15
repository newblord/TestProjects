using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DatabaseGenerationToolExt.Helpers;
using DatabaseGenerationToolExt.DatabaseGeneration.Models;

namespace DatabaseGenerationToolExt.DatabaseGeneration
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
			WHERE FK.name IN ('{TABLE_NAMES}') AND PK.name IN ('{TABLE_NAMES}')
			ORDER BY FK_Table, FK_Column";

		private const string IndexSQL = @"
			SELECT   
			s.name AS SchemaName
			,o.name AS TableName
			, i.name AS IndexName
			, i.is_unique AS IsUnique
			, c.name AS ColumnName
			, i.is_primary_key as IsPrimaryKey
			FROM sys.objects o
			INNER JOIN sys.schemas s ON s.schema_id = o.schema_id
			INNER JOIN sys.indexes i ON o.object_id = i.object_id
			INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id and i.index_id = ic.index_id
			INNER JOIN sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
			WHERE i.is_hypothetical = 0
				and ic.is_included_column = 0
				and o.name in ('{TABLE_NAMES}')
			ORDER BY TableName, IsUnique desc, IndexName, ic.key_ordinal";

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

		public static readonly List<string> ReservedKeywords = new List<string>
		  {
				"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
				"checked", "class", "const", "continue", "decimal", "default", "delegate", "do",
				"double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed",
				"float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface",
				"internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator",
				"out", "override", "params", "private", "protected", "public", "readonly", "ref",
				"return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string",
				"struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong",
				"unchecked", "unsafe", "ushort", "using", "virtual", "volatile", "void", "while"
		  };

		// Filtering **************************************************************************************************************************
		// Use the following table/view name regex filters to include or exclude tables/views
		// Exclude filters are checked first and tables matching filters are removed.
		//  * If left null, none are excluded.
		//  * If not null, any tables matching the regex are excluded.
		// Include filters are checked second.
		//  * If left null, all are included.
		//  * If not null, only the tables matching the regex are included.
		// For clarity: if you want to include all the customer tables, but not the customer billing tables.
		//		TableFilterInclude = new Regex("^[Cc]ustomer.*"); // This includes all the customer and customer billing tables
		//		TableFilterExclude = new Regex(".*[Bb]illing.*"); // This excludes all the billing tables
		//
		// Example:	  TableFilterExclude = new Regex(".*auto.*");
		//				  TableFilterInclude = new Regex("(.*_FR_.*)|(data_.*)");
		//				  TableFilterInclude = new Regex("^table_name1$|^table_name2$|etc");
		//				  ColumnFilterExclude = new Regex("^FK_.*$");
		private Regex SchemaFilterExclude = null;
		private Regex SchemaFilterInclude = null;
		private Regex TableFilterExclude = null;
		private Regex TableFilterInclude = null;
		private Regex ColumnFilterExclude = null;

		// Stored Procedures ******************************************************************************************************************
		// Use the following regex filters to include or exclude stored procedures
		private Regex StoredProcedureFilterExclude = null;
		private Regex StoredProcedureFilterInclude = null;

		// Column modification*****************************************************************************************************************
		// Use the following list to replace column byte types with Enums.
		// As long as the type can be mapped to your new type, all is well.
		//EnumsDefinitions.Add(new EnumDefinition { Schema = "dbo", Table = "match_table_name", Column = "match_column_name", EnumType = "name_of_enum" });
		//EnumsDefinitions.Add(new EnumDefinition { Schema = "dbo", Table = "OrderHeader", Column = "OrderStatus", EnumType = "OrderStatusType" }); // This will replace OrderHeader.OrderStatus type to be an OrderStatusType enum
		public static List<EnumDefinition> EnumsDefinitions = new List<EnumDefinition>();

		private static readonly Regex RxCleanUp = new Regex(@"[^\w\d\s_-]", RegexOptions.Compiled);

		private DbProviderFactory Factory { get; set; }

		protected DbCommand Cmd { get; }

		public SchemaReader()
		{
			Inflector.PluralizationService = new System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService();

			Factory = ConnectionHelper.GetDbProviderFactory(Global.Setting.ProviderName);

			if (Factory != null)
			{
				Cmd = Factory.CreateCommand();
			}

		}

		private string IncludeQueryTraceOn9481()
		{
			if (Global.Setting.IncludeQueryTraceOn9481Flag)
				return @"
				OPTION (QUERYTRACEON 9481)";
			return string.Empty;
		}

		private string ProcessTableSQL()
		{
			string sql = TableSQL.Replace("{TABLE_NAMES}", string.Join("', '", Global.SelectedTables.Select(x => x.TableName)));
			return sql;
		}

		private string ProcessForeignKeySQL()
		{
			string sql = ForeignKeySQL.Replace("{TABLE_NAMES}", string.Join("', '", Global.SelectedTables.Select(x => x.TableName)));
			return sql;
		}

		private string ProcessIndexSQL()
		{
			string sql = IndexSQL.Replace("{TABLE_NAMES}", string.Join("', '", Global.SelectedTables.Select(x => x.TableName)));
			return sql;
		}

		private string ProcessStoredProcSQL()
		{
			string sql = StoredProcedureSQL.Replace("{SPROC_NAMES}", string.Join("', '", Global.SelectedStoredProcedures.Select(x => x.StoredProcName)));
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

		private bool TableFilter(Table t)
		{
			// Example: Exclude any table in dbo schema with "order" in its name.
			//if(t.Schema.Equals("dbo", StringComparison.InvariantCultureIgnoreCase) && t.NameHumanCase.ToLowerInvariant().Contains("order"))
			//	 return false;

			return true;
		}

		// Table renaming *********************************************************************************************************************
		// Use the following function to rename tables such as tblOrders to Orders, Shipments_AB to Shipments, etc.
		// Example:
		private string TableRename(string name, string schema)
		{
			// Example
			//if (name.StartsWith("tbl"))
			//	 name = name.Remove(0, 3);
			//name = name.Replace("_AB", "");

			// If you turn camel casing off (Setting.UseCamelCase = false), and use the pluralisation service, and some of your
			// tables names are all UPPERCASE, some words ending in IES such as CATEGORIES get singularised as CATEGORy.
			// Therefore you can make them lowercase by using the following
			// return Inflector.MakeLowerIfAllCaps(name);

			return name;
		}

		// Use the following function if you need to apply additional modifications to a column
		// eg. normalise names etc.
		private Column UpdateColumn(Column column, Table table)
		{
			// Example
			//if (column.IsPrimaryKey)
			//	column.NameHumanCase = "Id";

			//if (column.NameHumanCase.EndsWith("Key"))
			//{
			//	column.NameHumanCase = column.NameHumanCase.Substring(0, column.NameHumanCase.LastIndexOf("Key")) + "Id";
			//}

			// .IsConcurrencyToken() must be manually configured. However .IsRowVersion() can be automatically detected.
			//if (table.NameHumanCase.Equals("SomeTable", StringComparison.InvariantCultureIgnoreCase) && column.NameHumanCase.Equals("SomeColumn", StringComparison.InvariantCultureIgnoreCase))
			//	 column.IsConcurrencyToken = true;

			// Remove table name from primary key
			//if (column.IsPrimaryKey && column.NameHumanCase.Equals(table.NameHumanCase + "Id", StringComparison.InvariantCultureIgnoreCase))
			//	 column.NameHumanCase = "Id";

			// Remove column from Model class as it will be inherited from a base class
			//if (column.IsPrimaryKey && table.NameHumanCase.Equals("SomeTable", StringComparison.InvariantCultureIgnoreCase))
			//	 column.Hidden = true;

			// Perform Enum property type replacement
			var enumDefinition = EnumsDefinitions.FirstOrDefault(e =>
				 (e.Schema.Equals(table.Schema, StringComparison.InvariantCultureIgnoreCase)) &&
				 (e.Table.Equals(table.Name, StringComparison.InvariantCultureIgnoreCase) || e.Table.Equals(table.NameHumanCase, StringComparison.InvariantCultureIgnoreCase)) &&
				 (e.Column.Equals(column.Name, StringComparison.InvariantCultureIgnoreCase) || e.Column.Equals(column.NameHumanCase, StringComparison.InvariantCultureIgnoreCase)));

			if (enumDefinition != null)
			{
				column.PropertyType = enumDefinition.EnumType;
				if (!string.IsNullOrEmpty(column.Default))
					column.Default = "(" + enumDefinition.EnumType + ") " + column.Default;
			}

			return column;
		}

		// StoredProcedure return types *******************************************************************************************************
		// Override generation of return models for stored procedures that return entities.
		// If a stored procedure returns an entity, add it to the list below.
		// This will suppress the generation of the return model, and instead return the entity.
		// Example:							  Proc name		Return this entity type instead
		//StoredProcedureReturnTypes.Add("SalesByYear", "SummaryOfSalesByYear");

		private ForeignKey ForeignKeyFilter(ForeignKey fk)
		{
			// Return null to exclude this foreign key
			// Example, to exclude all foreign keys for the Categories table, use:
			// if (fk.PkTableName == "Categories")
			//	 return null;
			return fk;
		}

		private string ForeignKeyName(string tableName, string foreignKeyName, short attempt)
		{
			// 5 Attempts to correctly name the foreign key
			switch (attempt)
			{
				case 1:
					// Try without appending foreign key name
					return tableName;

				case 2:
					// Only called if foreign key name ends with "id"
					// Use foreign key name without "id" at end of string
					return foreignKeyName.Remove(foreignKeyName.Length - 2, 2);

				case 3:
					// Use foreign key name only
					return foreignKeyName;

				case 4:
					// Use table name and foreign key name
					return tableName + "_" + foreignKeyName;

				case 5:
					// Used in for loop 1 to 99 to append a number to the end
					return tableName;

				default:
					// Give up
					return tableName;
			}
		}

		private string CleanUp(string str)
		{
			// Replace punctuation and symbols in variable names as these are not allowed.
			int len = str.Length;
			if (len == 0)
				return str;
			var sb = new StringBuilder();
			bool replacedCharacter = false;
			for (int n = 0; n < len; ++n)
			{
				char c = str[n];
				if (c != '_' && c != '-' && (char.IsSymbol(c) || char.IsPunctuation(c)))
				{
					int ascii = c;
					sb.AppendFormat("{0}", ascii);
					replacedCharacter = true;
					continue;
				}
				sb.Append(c);
			}
			if (replacedCharacter)
				str = sb.ToString();

			// Remove non alphanumerics
			str = RxCleanUp.Replace(str, "");
			if (char.IsDigit(str[0]))
				str = "C" + str;

			return str;
		}

		private string GetEnumerationNameFromSpellFunction(string spellFunctionName)
		{
			string returnVal = spellFunctionName.ToLower();

			returnVal = returnVal.Replace("fn_spell_", string.Empty).Replace("_", " ");

			returnVal = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(returnVal);
			returnVal = returnVal.Replace(" ", string.Empty);

			return returnVal;
		}

		private string ColumnNameToPropertyName(string columnName)
		{
			columnName = columnName.Trim().Replace("-", string.Empty).Replace('_', ' ').Replace('/', ' ');
			columnName = Regex.Replace(columnName, @"[^\w|\s]", string.Empty); // Remove all non-alphanumeric and non-whitespace characters.
																									 //columnName = Regex.Replace(columnName, "([a-z])([A-Z])", "$1_$2").ToUpper();
																									 //columnName = Regex.Replace(columnName.ToLower(), @"(?:^|_)([a-z])", match => match.Groups[1].Value.ToUpper());
			columnName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(columnName);
			columnName = Regex.Replace(columnName, @"\s", string.Empty);

			return columnName;
		}

		public Tables LoadTables()
		{
			if (Factory == null)
				return new Tables();

			try
			{
				using (DbConnection conn = Factory.CreateConnection())
				{
					conn.ConnectionString = Global.Setting.ConnectionString;
					conn.Open();
					Cmd.Connection = conn;

					var tables = ReadTables();
					tables.SetPrimaryKeys();

					var indexList = ReadIndexes(tables);
					ProcessIndexes(indexList, tables);

					// Must be done in this order
					var fkList = ReadForeignKeys();
					IdentifyForeignKeys(fkList, tables);
					ProcessForeignKeys(fkList, tables, true);

					tables.ResetNavigationProperties();
					ProcessForeignKeys(fkList, tables, false);

					foreach (var t in tables)
						t.SetHasPrimaryKey();

					conn.Close();
					return tables;
				}
			}
			catch (Exception ex)
			{
				return new Tables();
			}
		}

		public List<StoredProcedure> LoadStoredProcs()
		{
			if (Factory == null)
				return new List<StoredProcedure>();

			try
			{
				using (DbConnection conn = Factory.CreateConnection())
				{
					conn.ConnectionString = Global.Setting.ConnectionString;
					conn.Open();
					Cmd.Connection = conn;

					var storedProcs = ReadStoredProcedures();
					conn.Close();

					// Remove unrequired stored procs
					for (int i = storedProcs.Count - 1; i >= 0; i--)
					{
						if (SchemaFilterInclude != null && !SchemaFilterInclude.IsMatch(storedProcs[i].Schema))
						{
							storedProcs.RemoveAt(i);
							continue;
						}
						if (StoredProcedureFilterInclude != null && !StoredProcedureFilterInclude.IsMatch(storedProcs[i].Name))
						{
							storedProcs.RemoveAt(i);
							continue;
						}
					}

					using (var sqlConnection = new SqlConnection(Global.Setting.ConnectionString))
					{
						foreach (var proc in storedProcs)
							ReadStoredProcReturnObject(sqlConnection, proc);
					}

					// Remove stored procs where the return model type contains spaces and cannot be mapped
					var validStoredProcedures = new List<StoredProcedure>();
					foreach (var sp in storedProcs)
					{
						if (!sp.ReturnModels.Any())
						{
							validStoredProcedures.Add(sp);
							continue;
						}
						if (!sp.ReturnModels.Any(returnColumns => returnColumns.Any(c => c.ColumnName.Contains(" "))))
							validStoredProcedures.Add(sp);
					}
					return validStoredProcedures;
				}
			}
			catch (Exception ex)
			{
				return new List<StoredProcedure>();
			}
		}

		private string[] lineSeparator = new string[] { Environment.NewLine };
		private string[] paramterDefSeparator = new string[] { " as " };

		public List<Models.Enum> LoadEnums()
		{
			if (Global.SelectedEnums.Count == 0)
				return new List<Models.Enum>();

			try
			{
				List<Models.Enum> enums = new List<Models.Enum>();

				foreach (Forms.Models.EnumData selectedEnum in Global.SelectedEnums)
				{
					var lines = selectedEnum.FunctionRawText.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
					bool hasCaseStatment = false;
					string currentLine = null;

					Models.Enum newEnum = new Models.Enum();

					newEnum.EnumData = selectedEnum;
					newEnum.Name = GetEnumerationNameFromSpellFunction(selectedEnum.EnumName);

					foreach (var line in lines)
					{
						currentLine = line.Trim();
						if (currentLine.StartsWith("--"))
						{
							continue;
						}
						else if (currentLine.ToLower().Contains("create"))
						{
							// Find the function name.  This assumes that the sp_help procedure returns something like: 'CREATE function dbo.FN_Spell_COLUMN_NAME (@param int)'
							// The first group captures the text between the dbo. and ( for the , which is the FN_Spell_COLUMN_NAME portion.
							// The second group captures the type of the first parameter to the function, which is 'int' in the example.
							var match = System.Text.RegularExpressions.Regex.Match(currentLine, @"^create\s{1}function\s{1}(?:dbo|\[dbo\])?\.?(?:\w*)\s?\(@\w*\s(\w*)(?:,|\)){1}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
							if (match.Success)
							{
								if (match.Groups.Count > 1)
								{
									newEnum.TypeName = PropertyTypeHelper.GetPropertyType(match.Groups[1].Value,0,0);
								}
							}
						}
						else if (currentLine.ToLower().Contains("case "))
						{
							hasCaseStatment = true;
						}
						else if (currentLine.ToLower().Contains("when "))
						{
							// Find the function name.  This assumes that the sp_help procedure returns something like: "WHEN 'BB' THEN 'Welcome (No Password Sent)'"
							// The first group captures the text between the WHEN and THEN, which in the example is the 'BB' portion.
							// The second group captures the description, which is 'Welcome (No Password Sent)' in the example.
							var match = System.Text.RegularExpressions.Regex.Match(currentLine, @"when\s+'?(\w+)'?\s+then\s+'?([\w|\s|\(|\)\&]+)'?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
							if (match.Success)
							{
								if (match.Groups.Count > 2)
								{
									int numericTest = 0;

									EnumEntry entry = new EnumEntry()
									{
										Value = match.Groups[1].Value,
										Code = match.Groups[1].Value,
										Description = match.Groups[2].Value,
										Name = ColumnNameToPropertyName(match.Groups[2].Value),
										ValueIsNumeric = Int32.TryParse(match.Groups[1].Value, out numericTest)
									};
									newEnum.Entries.Add(entry);
								}
							}
						}
						else if (hasCaseStatment && currentLine.ToLower().Contains("end"))
						{
							break;
						}
					}

					enums.Add(newEnum);
				}

				return enums;
			}
			catch (Exception ex)
			{
				return new List<Models.Enum>();
			}
		}

		public Tables ReadTables()
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
					if (IsFilterExcluded(SchemaFilterExclude, SchemaFilterInclude, schema))
						continue;

					string tableName = rdr["TableName"].ToString().Trim();
					if (IsFilterExcluded(TableFilterExclude, TableFilterInclude, tableName))
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
								HasNullableColumns = false
							};

							table.TableData = Global.SelectedTables.Where(x => x.TableName.Equals(tableName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

							tableName = TableRename(tableName, schema);
							if (IsFilterExcluded(TableFilterExclude, null, tableName)) // Retest exclusion filter after table rename
								continue;

							// Handle table names with underscores - singularise just the last word
							table.ClassName = Inflector.MakeSingular(CleanUp(tableName));
							var titleCase = (Global.Setting.UseCamelCase ? Inflector.ToTitleCase(table.ClassName) : table.ClassName).Replace(" ", "").Replace("$", "").Replace(".", "");
							table.NameHumanCase = titleCase;


							if ((string.Compare(table.Schema, "dbo", StringComparison.OrdinalIgnoreCase) != 0) && Global.Setting.PrependSchemaName)
								table.NameHumanCase = table.Schema + "_" + table.NameHumanCase;

							// Check for table or C# name clashes
							if (ReservedKeywords.Contains(table.NameHumanCase) ||
								 (Global.Setting.UseCamelCase && result.Find(x => x.NameHumanCase == table.NameHumanCase) != null))
							{
								table.NameHumanCase += "1";
							}

							if (!TableFilter(table))
								continue;

							result.Add(table);
						}
					}

					var col = CreateColumn(rdr, rxClean, table);
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
				tbl.Columns.ForEach(x => x.SetupEntityAndConfig(Global.Setting.IncludeComments));
			}

			return result;
		}

		public List<ForeignKey> ReadForeignKeys()
		{
			var fkList = new List<ForeignKey>();
			if (Cmd == null)
				return fkList;

			Cmd.CommandText = ProcessForeignKeySQL() + IncludeQueryTraceOn9481();
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

					string fkTableNameFiltered = TableRename(fkTableName, fkSchema);
					string pkTableNameFiltered = TableRename(pkTableName, pkSchema);

					var fk = new ForeignKey(fkTableName, fkSchema, pkTableName, pkSchema, fkColumn, pkColumn,
							  constraintName, fkTableNameFiltered, pkTableNameFiltered, ordinal, cascadeOnDelete);

					var filteredFk = ForeignKeyFilter(fk);
					if (filteredFk != null)
						fkList.Add(filteredFk);
				}
			}

			return fkList;
		}

		public List<Index> ReadIndexes(Tables tables)
		{
			var indexes = new List<Index>();
			if (Cmd == null)
				return indexes;

			Cmd.CommandText = ProcessIndexSQL() + IncludeQueryTraceOn9481();
			Cmd.CommandTimeout = 600;

			using (DbDataReader rdr = Cmd.ExecuteReader())
			{
				while (rdr.Read())
				{
					Table table = tables.GetTable(rdr["TableName"] as string, rdr["SchemaName"] as string);
					Index index = indexes.Where(x => x.TableName == table.NameHumanCase && x.IndexName == rdr["IndexName"] as string).FirstOrDefault();

					if (index == null)
					{
						index = new Index
						{
							IndexName = rdr["IndexName"] as string,
							SchemaName = table.Schema,
							TableName = table.NameHumanCase,
							IsUnique = (bool)rdr["IsUnique"],
							IsPrimaryKey = (bool)rdr["IsPrimaryKey"]
						};

						indexes.Add(index);
					}

					var column = (from c in table.Columns
									  where c.Name == (rdr["ColumnName"] as string)
									  select c).FirstOrDefault();

					if (column != null)
					{
						index.Columns.Add(column);
					}

					index.ColumnString = string.Join(",", index.Columns.Select(s => s.NameHumanCase.ToLower()).OrderBy(o => o));
				}
			}

			return indexes;
		}

		public List<StoredProcedure> ReadStoredProcedures()
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
					if (SchemaFilterExclude != null && SchemaFilterExclude.IsMatch(schema))
						continue;

					string spName = rdr["SPECIFIC_NAME"].ToString().Trim();

					var fullname = schema + "." + spName;

					if (StoredProcedureFilterExclude != null && (StoredProcedureFilterExclude.IsMatch(spName) || StoredProcedureFilterExclude.IsMatch(fullname)))
						continue;

					if (lastSp != fullname || sp == null)
					{
						lastSp = fullname;
						sp = new StoredProcedure
						{
							Name = spName,
							NameHumanCase = (Global.Setting.UseCamelCase ? Inflector.ToTitleCase(spName) : spName).Replace(" ", "").Replace("$", ""),
							Schema = schema
						};
						if ((string.Compare(schema, "dbo", StringComparison.OrdinalIgnoreCase) != 0) && Global.Setting.PrependSchemaName)
							sp.NameHumanCase = schema + "_" + sp.NameHumanCase;

						sp.NameHumanCase = StoredProcedureHelper.StoredProcedureRename(sp.NameHumanCase, schema);

						if (StoredProcedureFilterExclude != null && StoredProcedureFilterExclude.IsMatch(sp.NameHumanCase))
							continue;

						sp.StoredProcData = Global.SelectedStoredProcedures.Where(x => x.StoredProcName.Equals(sp.Name, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

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
							SqlDbType = PropertyTypeHelper.GetSqlDbType(typename, scale, precision),
							PropertyType = PropertyTypeHelper.GetPropertyType(typename, scale, precision),
							DateTimePrecision = (Int16)rdr["DATETIME_PRECISION"],
							MaxLength = (int)rdr["CHARACTER_MAXIMUM_LENGTH"],
							Precision = precision,
							Scale = scale,
							UserDefinedTypeName = rdr["USER_DEFINED_TYPE"].ToString().Trim()
						};

						var clean = CleanUp(param.Name.Replace("@", ""));
						param.NameHumanCase =
							 Inflector.MakeInitialLower(
								  (Global.Setting.UseCamelCase ? Inflector.ToTitleCase(clean) : clean).Replace(" ", ""));

						if (ReservedKeywords.Contains(param.NameHumanCase))
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

		public void ProcessForeignKeys(List<ForeignKey> fkList, Tables tables, bool checkForFkNameClashes)
		{
			var constraints = fkList.Select(x => x.FkSchema + "." + x.ConstraintName).Distinct();
			foreach (var constraint in constraints)
			{
				var foreignKeys = fkList
						  .Where(x => string.Format("{0}.{1}", x.FkSchema, x.ConstraintName).Equals(constraint, StringComparison.InvariantCultureIgnoreCase))
						  .ToList();

				var foreignKey = foreignKeys.First();

				Table fkTable = foreignKey.FKTable;

				Table pkTable = foreignKey.PKTable;

				var fkCols = foreignKeys.Select(x => new
				{
					fkOrdinal = x.Ordinal,
					col = fkTable.Columns.Find(n => string.Equals(n.Name, x.FkColumnName, StringComparison.InvariantCultureIgnoreCase))
				})
					 .Where(x => x != null)
					 .ToList();

				if (!fkCols.Any())
					continue;

				var pkCols = foreignKeys.Select(x => pkTable.Columns.Find(n => string.Equals(n.Name, x.PkColumnName, StringComparison.InvariantCultureIgnoreCase)))
														  .Where(x => x != null && x.IsPrimaryKey)
														  .OrderBy(o => o.Ordinal)
														  .ToList();

				if (!pkCols.Any())
					continue;

				var fkCol = fkCols.First();
				var pkCol = pkCols.First();

				var relationship = CalcRelationship(pkTable, fkTable, fkCols.OrderBy(o => o.fkOrdinal).Select(c => c.col).ToList(), pkCols);
				if (relationship == Relationship.DoNotUse)
					continue;

				string pkTableHumanCase = foreignKey.PkTableHumanCase(Global.Setting.UseCamelCase, Global.Setting.PrependSchemaName);
				string pkPropName = fkTable.GetUniqueColumnName(pkTableHumanCase, foreignKey, Global.Setting.UseCamelCase, checkForFkNameClashes, true, ForeignKeyName);
				bool fkMakePropNameSingular = (relationship == Relationship.OneToOne);
				string fkPropName = pkTable.GetUniqueColumnName(fkTable.NameHumanCase, foreignKey, Global.Setting.UseCamelCase, checkForFkNameClashes, fkMakePropNameSingular, ForeignKeyName);

				fkCol.col.EntityForeignKeys.Add(string.Format("public virtual {0} {1} {2}{3}", pkTableHumanCase, pkPropName, "{ get; set; }", Global.Setting.IncludeComments != CommentsStyle.None ? " // " + foreignKey.ConstraintName : string.Empty));

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

				fkCol.col.ConfigForeignKeys.Add(string.Format("{0};{1}", GetRelationship(relationship, fkCol.col, pkCol, pkPropName, fkPropName, manyToManyMapping, mapKey, foreignKey.CascadeOnDelete), Global.Setting.IncludeComments != CommentsStyle.None ? " // " + foreignKey.ConstraintName : string.Empty));

				var rv = new ReverseNavigation(relationship, pkTableHumanCase, pkCol, fkTable, fkPropName, fkCol.col, constraint, Global.Setting.IncludeComments);
				pkTable.ReverseNavigationProperties.Add(rv);
			}
		}

		public void ProcessIndexes(List<Index> indexList, Tables tables)
		{
			foreach (Index index in indexList)
			{
				Table table = tables.GetTable(index.TableName, index.SchemaName);

				if (table == null)
					continue;

				if (!(index.Columns.Count == 1 && index.Columns.First().IsPrimaryKey))
				{
					table.Indexes.Add(index);
				}
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

				Column fkCol = fkTable.Columns.Find(n => string.Equals(n.Name, foreignKey.FkColumnName, StringComparison.InvariantCultureIgnoreCase));
				if (fkCol == null)
					continue;   // Could not find fk column

				Column pkCol = pkTable.Columns.Find(n => string.Equals(n.Name, foreignKey.PkColumnName, StringComparison.InvariantCultureIgnoreCase));
				if (pkCol == null)
					continue;   // Could not find pk column

				foreignKey.FKTable = fkTable;
				foreignKey.PKTable = pkTable;
				foreignKey.FKColumn = fkCol;
				foreignKey.PKColumn = pkCol;

				fkTable.ForeignKeys.Add(foreignKey);
			}
		}

		private Relationship CalcRelationship(Table pkTable, Table fkTable, List<Column> fkCols, List<Column> pkCols)
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

		private Relationship CalcRelationshipSingle(Table pkTable, Table fkTable, Column fkCol, Column pkCol)
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

		private Column CreateColumn(IDataRecord rdr, Regex rxClean, Table table)
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
				PropertyType = PropertyTypeHelper.GetPropertyType(typename, scale, precision),
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
			if (ColumnFilterExclude != null && !col.IsPrimaryKey && (ColumnFilterExclude.IsMatch(col.Name) || ColumnFilterExclude.IsMatch(fullName)))
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
			col.NameHumanCase = CleanUp(col.Name);
			col.NameHumanCase = rxClean.Replace(col.NameHumanCase, "_$1");

			if (ReservedKeywords.Contains(col.NameHumanCase))
				col.NameHumanCase = "@" + col.NameHumanCase;

			var titleCase = (Global.Setting.UseCamelCase ? Inflector.ToTitleCase(col.NameHumanCase) : col.NameHumanCase).Replace(" ", "");
			if (titleCase != string.Empty)
				col.NameHumanCase = titleCase;

			// Make sure property name doesn't clash with class name
			if (col.NameHumanCase == table.NameHumanCase)
				col.NameHumanCase = col.NameHumanCase + "_";

			if (char.IsDigit(col.NameHumanCase[0]))
				col.NameHumanCase = "_" + col.NameHumanCase;

			table.HasNullableColumns = col.IsNullable;

			col = UpdateColumn(col, table);

			col.ParameterName = Inflector.MakeInitialLower(col.NameHumanCase);

			// If PropertyType is empty, return null. Most likely ignoring a column due to legacy (such as OData not supporting spatial types)
			if (string.IsNullOrEmpty(col.PropertyType))
				return null;

			return col;
		}
	}
}
