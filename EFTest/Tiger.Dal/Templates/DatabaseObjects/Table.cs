using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class Table
	{
		public string Name;
		public string NameHumanCase;
		public string Schema;
		public string Type;
		public string ClassName;
		public bool IsMapping;
		public bool IsView;
		public bool HasForeignKey;
		public bool HasNullableColumns;
		public bool HasPrimaryKey;
		public TableData TableData;

		public List<Column> Columns;
		public List<string> ReverseNavigationProperty;
		public List<string> MappingConfiguration;
		public List<string> ReverseNavigationCtor;
		public List<string> ReverseNavigationUniquePropName;
		public List<string> ReverseNavigationUniquePropNameClashes;

		public Table()
		{
			Columns = new List<Column>();
			ResetNavigationProperties();
			ReverseNavigationUniquePropNameClashes = new List<string>();
		}

		public void ResetNavigationProperties()
		{
			MappingConfiguration = new List<string>();
			ReverseNavigationProperty = new List<string>();
			ReverseNavigationCtor = new List<string>();
			ReverseNavigationUniquePropName = new List<string>();
			foreach (var col in Columns)
				col.ResetNavigationProperties();
		}

		public void SetHasPrimaryKey()
		{
			HasPrimaryKey = Columns.Any(x => x.IsPrimaryKey);
		}

		public IEnumerable<Column> PrimaryKeys
		{
			get
			{
				return Columns.Where(x => x.IsPrimaryKey)
								.OrderBy(x => x.PrimaryKeyOrdinal)
								.ThenBy(x => x.Ordinal)
								.ToList();
			}
		}

		public string PrimaryKeyNameHumanCase()
		{
			var data = PrimaryKeys.Select(x => "x." + x.NameHumanCase).ToList();
			int n = data.Count();
			if (n == 0)
				return string.Empty;
			if (n == 1)
				return "x => " + data.First();
			// More than one primary key
			return string.Format("x => new {{ {0} }}", string.Join(", ", data));
		}

		public Column this[string columnName]
		{
			get { return GetColumn(columnName); }
		}

		public Column GetColumn(string columnName)
		{
			return Columns.SingleOrDefault(x => String.Compare(x.Name, columnName, StringComparison.OrdinalIgnoreCase) == 0);
		}

		public string GetUniqueColumnName(string tableNameHumanCase, ForeignKey foreignKey, bool useCamelCase, bool checkForFkNameClashes, bool makeSingular, Func<string, string, short, string> ForeignKeyName)
		{
			if (ReverseNavigationUniquePropName.Count == 0)
			{
				ReverseNavigationUniquePropName.Add(NameHumanCase);
				ReverseNavigationUniquePropName.AddRange(Columns.Select(c => c.NameHumanCase));
			}

			if (!makeSingular)
				tableNameHumanCase = Inflector.MakePlural(tableNameHumanCase);

			if (checkForFkNameClashes && ReverseNavigationUniquePropName.Contains(tableNameHumanCase) && !ReverseNavigationUniquePropNameClashes.Contains(tableNameHumanCase))
				ReverseNavigationUniquePropNameClashes.Add(tableNameHumanCase); // Name clash

			// Attempt 1
			string fkName = (useCamelCase ? Inflector.ToTitleCase(foreignKey.FkColumn) : foreignKey.FkColumn).Replace(" ", "").Replace("$", "");
			string name = ForeignKeyName(tableNameHumanCase, fkName, 1);
			string col;
			if (!ReverseNavigationUniquePropNameClashes.Contains(name) && !ReverseNavigationUniquePropName.Contains(name))
			{
				ReverseNavigationUniquePropName.Add(name);
				return name;
			}

			// Attempt 2
			if (fkName.ToLowerInvariant().EndsWith("id"))
			{
				col = ForeignKeyName(tableNameHumanCase, fkName, 2);
				if (checkForFkNameClashes && ReverseNavigationUniquePropName.Contains(col) &&
					!ReverseNavigationUniquePropNameClashes.Contains(col))
					ReverseNavigationUniquePropNameClashes.Add(col); // Name clash

				if (!ReverseNavigationUniquePropNameClashes.Contains(col) &&
					!ReverseNavigationUniquePropName.Contains(col))
				{
					ReverseNavigationUniquePropName.Add(col);
					return col;
				}
			}

			// Attempt 3
			col = ForeignKeyName(tableNameHumanCase, fkName, 3);
			if (checkForFkNameClashes && ReverseNavigationUniquePropName.Contains(col) &&
				!ReverseNavigationUniquePropNameClashes.Contains(col))
				ReverseNavigationUniquePropNameClashes.Add(col); // Name clash

			if (!ReverseNavigationUniquePropNameClashes.Contains(col) &&
				!ReverseNavigationUniquePropName.Contains(col))
			{
				ReverseNavigationUniquePropName.Add(col);
				return col;
			}

			// Attempt 4
			col = ForeignKeyName(tableNameHumanCase, fkName, 4);
			if (checkForFkNameClashes && ReverseNavigationUniquePropName.Contains(col) && !ReverseNavigationUniquePropNameClashes.Contains(col))
				ReverseNavigationUniquePropNameClashes.Add(col); // Name clash

			if (!ReverseNavigationUniquePropNameClashes.Contains(col) && !ReverseNavigationUniquePropName.Contains(col))
			{
				ReverseNavigationUniquePropName.Add(col);
				return col;
			}

			// Attempt 5
			for (int n = 1; n < 99; ++n)
			{
				col = ForeignKeyName(tableNameHumanCase, fkName, 5) + n;

				if (ReverseNavigationUniquePropName.Contains(col))
					continue;

				ReverseNavigationUniquePropName.Add(col);
				return col;
			}

			// Give up
			return ForeignKeyName(tableNameHumanCase, fkName, 6);
		}

		public void AddReverseNavigation(Relationship relationship, string fkName, Table fkTable, string propName, string constraint, string collectionType, CommentsStyle includeComments)
		{
			switch (relationship)
			{
				case Relationship.OneToOne:
					ReverseNavigationProperty.Add(string.Format("public virtual {0} {1} {{ get; set; }}{2}", fkTable.NameHumanCase, propName, includeComments != CommentsStyle.None ? " // " + constraint : string.Empty));
					break;

				case Relationship.OneToMany:
					ReverseNavigationProperty.Add(string.Format("public virtual {0} {1} {{ get; set; }}{2}", fkTable.NameHumanCase, propName, includeComments != CommentsStyle.None ? " // " + constraint : string.Empty));
					break;

				case Relationship.ManyToOne:
					ReverseNavigationProperty.Add(string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", fkTable.NameHumanCase, propName, includeComments != CommentsStyle.None ? " // " + constraint : string.Empty));
					ReverseNavigationCtor.Add(string.Format("{0} = new {1}<{2}>();", propName, collectionType, fkTable.NameHumanCase));
					break;

				case Relationship.ManyToMany:
					ReverseNavigationProperty.Add(string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", fkTable.NameHumanCase, propName, includeComments != CommentsStyle.None ? " // Many to many mapping" : string.Empty));
					ReverseNavigationCtor.Add(string.Format("{0} = new {1}<{2}>();", propName, collectionType, fkTable.NameHumanCase));
					break;

				default:
					throw new ArgumentOutOfRangeException("relationship");
			}
		}

		public void AddMappingConfiguration(ForeignKey left, ForeignKey right, bool useCamelCase, string leftPropName, string rightPropName)
		{
			MappingConfiguration.Add(string.Format(@"HasMany(t => t.{0}).WithMany(t => t.{1}).Map(m =>
			{{
					m.ToTable(""{2}""{5});
					m.MapLeftKey(""{3}"");
					m.MapRightKey(""{4}"");
			}});", leftPropName, rightPropName, left.FkTableName, left.FkColumn, right.FkColumn, ", \"" + left.FkSchema + "\""));
		}

		public void SetPrimaryKeys()
		{
			if (PrimaryKeys.Any())
				return; // Table has at least one primary key

			// This table is not allowed in EntityFramework as it does not have a primary key.
			// Therefore generate a composite key from all non-null fields.
			foreach (var col in Columns.Where(x => !x.IsNullable && !x.Hidden))
			{
				col.IsPrimaryKey = true;
			}
		}

		public void IdentifyMappingTable(List<ForeignKey> fkList, Tables tables, bool useCamelCase, string collectionType, bool checkForFkNameClashes, CommentsStyle includeComments, Func<string, string, short, string> ForeignKeyName)
		{
			IsMapping = false;

			var nonReadOnlyColumns = Columns.Where(c => !c.IsIdentity && !c.IsRowVersion && !c.IsStoreGenerated && !c.Hidden).ToList();

			// Ignoring read-only columns, it must have only 2 columns to be a mapping table
			if (nonReadOnlyColumns.Count != 2)
				return;

			// Must have 2 primary keys
			if (nonReadOnlyColumns.Count(x => x.IsPrimaryKey) != 2)
				return;

			// No columns should be nullable
			if (nonReadOnlyColumns.Any(x => x.IsNullable))
				return;

			// Find the foreign keys for this table
			var foreignKeys = fkList.Where(x =>
													String.Compare(x.FkTableName, Name, StringComparison.OrdinalIgnoreCase) == 0 &&
													String.Compare(x.FkSchema, Schema, StringComparison.OrdinalIgnoreCase) == 0)
											.ToList();

			// Each column must have a foreign key, therefore check column and foreign key counts match
			if (foreignKeys.Select(x => x.FkColumn).Distinct().Count() != 2)
				return;

			ForeignKey left = foreignKeys[0];
			ForeignKey right = foreignKeys[1];

			Table leftTable = tables.GetTable(left.PkTableName, left.PkSchema);
			if (leftTable == null)
				return;

			Table rightTable = tables.GetTable(right.PkTableName, right.PkSchema);
			if (rightTable == null)
				return;

			var leftPropName = leftTable.GetUniqueColumnName(rightTable.NameHumanCase, right, useCamelCase, checkForFkNameClashes, false, ForeignKeyName);
			var rightPropName = rightTable.GetUniqueColumnName(leftTable.NameHumanCase, left, useCamelCase, checkForFkNameClashes, false, ForeignKeyName);
			leftTable.AddMappingConfiguration(left, right, useCamelCase, leftPropName, rightPropName);

			IsMapping = true;
			rightTable.AddReverseNavigation(Relationship.ManyToMany, rightTable.NameHumanCase, leftTable, rightPropName, null, collectionType, includeComments);
			leftTable.AddReverseNavigation(Relationship.ManyToMany, leftTable.NameHumanCase, rightTable, leftPropName, null, collectionType, includeComments);
		}
	}
}
