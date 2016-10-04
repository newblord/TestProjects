using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tiger.Dal.Templates.DatabaseObjects;
using System.Data.Entity.Infrastructure.Pluralization;

namespace Tiger.Dal.Templates
{
	public class ReversePocoCore
	{

		public ReversePocoCore(DatabaseGenerationSetting setting)
		{
			Setting = setting;

			// Pluralization **********************************************************************************************************************
			// To turn off pluralization, use:
			//		Inflector.PluralizationService = null;
			// Default pluralization, use:
			//		Inflector.PluralizationService = new EnglishPluralizationService();
			// For Spanish pluralization:
			//		1. Intall the "EF6.Contrib" Nuget Package.
			//		2. Add the following to the top of this file and adjust path, and remove the space between the angle bracket and # at the beginning and end.
			//			< #@ assembly name="your full path to \EntityFramework.Contrib.dll" # >
			//		3. Change the line below to: Inflector.PluralizationService = new SpanishPluralizationService();

			// If pluralisation does not do the right thing, override it here by adding in a custom entry.
			//Inflector.PluralizationService = new EnglishPluralizationService(new[]
			//{
			//	 // Create custom ("Singular", "Plural") forms for one-off words as needed.
			//	 new CustomPluralizationEntry("Course", "Courses"),
			//	 new CustomPluralizationEntry("Status", "Status") // Use same value to prevent pluralisation
			//});

			Inflector.PluralizationService = new EnglishPluralizationService();
		}

		public static DatabaseGenerationSetting Setting { get; set; }

		public static readonly List<string> NotNullable = new List<string>
		{
			"string",
			"byte[]",
			"datatable",
			"system.data.datatable",
			"object",
			"microsoft.sqlserver.types.sqlgeography",
			"microsoft.sqlserver.types.sqlgeometry",
			"system.data.entity.spatial.dbgeography",
			"system.data.entity.spatial.dbgeometry",
			"system.data.entity.hierarchy.hierarchyid"
		};

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

		#region Basic Configuration

		public static List<EnumDefinition> EnumsDefinitions = new List<EnumDefinition>();
		public static Dictionary<string, string> StoredProcedureReturnTypes = new Dictionary<string, string>();

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
		Regex SchemaFilterExclude = null;
		Regex SchemaFilterInclude = null;
		Regex TableFilterExclude = null;
		Regex TableFilterInclude = null;
		Regex ColumnFilterExclude = null;

		// Filtering of tables using a function. This can be used in conjunction with the Regex's above.
		// Regex are used first to filter the list down, then this function is run last.
		// Return true to include the table, return false to exclude it.
		Func<Table, bool> TableFilter = (Table t) =>
		{
			// Example: Exclude any table in dbo schema with "order" in its name.
			//if(t.Schema.Equals("dbo", StringComparison.InvariantCultureIgnoreCase) && t.NameHumanCase.ToLowerInvariant().Contains("order"))
			//	 return false;

			return true;
		};

		// Stored Procedures ******************************************************************************************************************
		// Use the following regex filters to include or exclude stored procedures
		Regex StoredProcedureFilterExclude = null;
		Regex StoredProcedureFilterInclude = null;


		// Table renaming *********************************************************************************************************************
		// Use the following function to rename tables such as tblOrders to Orders, Shipments_AB to Shipments, etc.
		// Example:
		Func<string, string, string>  TableRename = (name, schema) =>
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
		};

		// Column modification*****************************************************************************************************************
		// Use the following list to replace column byte types with Enums.
		// As long as the type can be mapped to your new type, all is well.
		//EnumsDefinitions.Add(new EnumDefinition { Schema = "dbo", Table = "match_table_name", Column = "match_column_name", EnumType = "name_of_enum" });
		//EnumsDefinitions.Add(new EnumDefinition { Schema = "dbo", Table = "OrderHeader", Column = "OrderStatus", EnumType = "OrderStatusType" }); // This will replace OrderHeader.OrderStatus type to be an OrderStatusType enum

		// Use the following function if you need to apply additional modifications to a column
		// eg. normalise names etc.
		Func<Column, Table, Column> UpdateColumn = (Column column, Table table) =>
		{
			// Example
			if (column.IsPrimaryKey)
				column.NameHumanCase = "Id";

			if (column.NameHumanCase.EndsWith("Key"))
			{
				column.NameHumanCase = column.NameHumanCase.Substring(0,column.NameHumanCase.LastIndexOf("Key")) + "Id";
			}

			// .IsConcurrencyToken() must be manually configured. However .IsRowVersion() can be automatically detected.
			//if (table.NameHumanCase.Equals("SomeTable", StringComparison.InvariantCultureIgnoreCase) && column.NameHumanCase.Equals("SomeColumn", StringComparison.InvariantCultureIgnoreCase))
			//	 column.IsConcurrencyToken = true;

			// Remove table name from primary key
			//if (column.IsPrimaryKey && column.NameHumanCase.Equals(table.NameHumanCase + "Id", StringComparison.InvariantCultureIgnoreCase))
			//	 column.NameHumanCase = "Id";

			// Remove column from poco class as it will be inherited from a base class
			//if (column.IsPrimaryKey && table.NameHumanCase.Equals("SomeTable", StringComparison.InvariantCultureIgnoreCase))
			//	 column.Hidden = true;

			// Perform Enum property type replacement
			var enumDefinition = EnumsDefinitions.FirstOrDefault(e =>
				(e.Schema.Equals(table.Schema, StringComparison.InvariantCultureIgnoreCase)) &&
				(e.Table.Equals(table.Name, StringComparison.InvariantCultureIgnoreCase) || e.Table.Equals(table.NameHumanCase, StringComparison.InvariantCultureIgnoreCase)) &&
				(e.Column.Equals(column.Name, StringComparison.InvariantCultureIgnoreCase) || e.Column.Equals(column.NameHumanCase, StringComparison.InvariantCultureIgnoreCase)));

			if (enumDefinition != null)
				column.PropertyType = enumDefinition.EnumType;

			return column;
		};

		// StoredProcedure renaming ************************************************************************************************************
		// Use the following function to rename stored procs such as sp_CreateOrderHistory to CreateOrderHistory, my_sp_shipments to Shipments, etc.
		// Example:
		/*StoredProcedureRename = (name, schema) =>
		{
			if (name.StartsWith("sp_"))
				name = name.Remove(0, 3);
			return name.Replace("my_sp_", "");
		};*/
		Func<string, string, string> StoredProcedureRename = (name, schema) => name;  // Do nothing by default

		// StoredProcedure return types *******************************************************************************************************
		// Override generation of return models for stored procedures that return entities.
		// If a stored procedure returns an entity, add it to the list below.
		// This will suppress the generation of the return model, and instead return the entity.
		// Example:							  Proc name		Return this entity type instead
		//StoredProcedureReturnTypes.Add("SalesByYear", "SummaryOfSalesByYear");

		Func<ForeignKey, ForeignKey> ForeignKeyFilter = (ForeignKey fk) =>
		{
			// Return null to exclude this foreign key
			// Example, to exclude all foreign keys for the Categories table, use:
			// if (fk.PkTableName == "Categories")
			//	 return null;
			return fk;
		};

		Func<string, string, short, string> ForeignKeyName = (tableName, foreignKeyName, attempt) =>
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
					return foreignKeyName.Remove(foreignKeyName.Length-2, 2);

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
		};

		#endregion

		private static readonly Regex RxCleanUp = new Regex(@"[^\w\d\s_-]", RegexOptions.Compiled);

		public static readonly Func<string, string> CleanUp = (str) =>
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
		};

		public static void ArgumentNotNull<T>(T arg, string name) where T : class
		{
			if (arg == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		public static bool IsNullable(Column col)
		{
			return col.IsNullable && !NotNullable.Contains(col.PropertyType.ToLower());
		}

		public static void ProcessDatabaseXML(string templateFileName, ref List<string> tableNames, ref List<string> storedProcedureNames)
		{
			string fileName = templateFileName.Replace(".tt", "") + ".xml";

			if (System.IO.File.Exists(fileName))
			{
				var xml = XDocument.Load(fileName);

				tableNames = (from c in xml.Root.Descendants("Table")
								  select c.Value).ToList();

				storedProcedureNames = (from c in xml.Root.Descendants("StoredProcedure")
												select c.Value).ToList();
			}
		}

		#region Database Object Generation
		public Tables LoadTables(DbProviderFactory factory, string connectionString, List<string> tableNames)
		{
			//if (factory == null || !(ElementsToGenerate.HasFlag(Elements.Poco) ||
			//								ElementsToGenerate.HasFlag(Elements.Context) ||
			//								ElementsToGenerate.HasFlag(Elements.UnitOfWork) ||
			//								ElementsToGenerate.HasFlag(Elements.PocoConfiguration)))
			//	return new Tables();

			try
			{
				using (DbConnection conn = factory.CreateConnection())
				{
					conn.ConnectionString = connectionString;
					conn.Open();

					var reader = new SchemaReader(conn, factory, Setting.IncludeQueryTraceOn9481Flag);
					reader.TableNames = tableNames;

					var tables = reader.ReadSchema(SchemaFilterExclude, SchemaFilterInclude, TableFilterExclude, TableFilterInclude, ColumnFilterExclude, TableFilter, Setting.UseCamelCase, Setting.PrependSchemaName, Setting.IncludeComments, TableRename, UpdateColumn, Setting.PrivateSetterForComputerColumns);
					tables.SetPrimaryKeys();

					// Must be done in this order
					var fkList = reader.ReadForeignKeys(TableRename, ForeignKeyFilter);
					reader.IdentifyForeignKeys(fkList, tables);
					reader.ProcessForeignKeys(fkList, tables, Setting.UseCamelCase, Setting.PrependSchemaName, Setting.CollectionType, true, Setting.IncludeComments, ForeignKeyName);

					tables.ResetNavigationProperties();
					reader.ProcessForeignKeys(fkList, tables, Setting.UseCamelCase, Setting.PrependSchemaName, Setting.CollectionType, false, Setting.IncludeComments, ForeignKeyName);

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

		public List<StoredProcedure> LoadStoredProcs(DbProviderFactory factory, string connectionString, List<string> storedProcedureNames)
		{
			if (factory == null)
				return new List<StoredProcedure>();

			try
			{
				using (DbConnection conn = factory.CreateConnection())
				{
					conn.ConnectionString = connectionString;
					conn.Open();

					var reader = new SchemaReader(conn, factory, Setting.IncludeQueryTraceOn9481Flag);
					reader.StoredProcedureNames = storedProcedureNames;

					var storedProcs = reader.ReadStoredProcs(SchemaFilterExclude, StoredProcedureFilterExclude, Setting.UseCamelCase, Setting.PrependSchemaName, StoredProcedureRename);
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

					using (var sqlConnection = new SqlConnection(Setting.ConnectionString))
					{
						foreach (var proc in storedProcs)
							reader.ReadStoredProcReturnObject(sqlConnection, proc);
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

		#endregion
	}
}
