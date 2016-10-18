﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class Table
	{
		public string Name { get; set; }
		public string NameHumanCase { get; set; }
		public string Schema { get; set; }
		public string Type { get; set; }
		public string ClassName { get; set; }
		public bool IsMapping { get; set; }
		public bool IsView { get; set; }
		public bool HasForeignKey
		{
			get
			{
				return ForeignKeys.Any();
			}
		}
		public bool HasNullableColumns { get; set; }
		public bool HasPrimaryKey { get; set; }
		public TableData TableData { get; set; }

		public List<Column> Columns { get; set; }
		public List<ForeignKey> ForeignKeys { get; set; }
		public List<Index> Indexes { get; set; }
		public List<string> ReverseNavigationProperty { get; set; }
		public List<string> ReverseNavigationCtor { get; set; }
		public List<string> ReverseNavigationUniquePropName { get; set; }
		public List<string> ReverseNavigationUniquePropNameClashes { get; set; }

		public Table()
		{
			Columns = new List<Column>();
			ForeignKeys = new List<ForeignKey>();
			Indexes = new List<Index>();
			ResetNavigationProperties();
			ReverseNavigationUniquePropNameClashes = new List<string>();
		}

		public void ResetNavigationProperties()
		{
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
			string fkName = (useCamelCase ? Inflector.ToTitleCase(foreignKey.FkColumnName) : foreignKey.FkColumnName).Replace(" ", "").Replace("$", "");
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

		public void AddReverseNavigation(Relationship relationship, string fkName, Table fkTable, string propName, string constraint, CommentsStyle includeComments)
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
					ReverseNavigationCtor.Add(string.Format("{0} = new HashSet<{1}>();", propName, fkTable.NameHumanCase));
					break;

				case Relationship.ManyToMany:
					ReverseNavigationProperty.Add(string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", fkTable.NameHumanCase, propName, includeComments != CommentsStyle.None ? " // Many to many mapping" : string.Empty));
					ReverseNavigationCtor.Add(string.Format("{0} = new HashSet<{1}>();", propName, fkTable.NameHumanCase));
					break;

				default:
					throw new ArgumentOutOfRangeException("relationship");
			}
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

	}
}
