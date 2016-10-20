using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class ReverseNavigation
	{
		public Relationship Relationship { get; }
		public Column PKColumn { get; }
		public Table FKTable { get; }
		public Column FKColumn { get; }
		public string Constriant { get; }
		public CommentsStyle IncludeComments { get; }
		public string PropertyString { get; }
		public string ConstructorString { get; }
		public bool HasConstructorString
		{
			get
			{
				return !string.IsNullOrEmpty(ConstructorString);
			}
		}

		public ReverseNavigation(Relationship relationship, Column pkColumn, Table fkTable, Column fkColumn, string constraint, CommentsStyle includeComments)
		{
			Relationship = relationship;
			PKColumn = pkColumn;
			FKTable = fkTable;
			FKColumn = fkColumn;
			Constriant = Constriant;
			IncludeComments = includeComments;

			PropertyString = GeneratePropertyString();
			ConstructorString = GenerateConstructorString();
		}

		private string GeneratePropertyString()
		{
			switch (Relationship)
			{
				case Relationship.OneToOne:
					return string.Format("public virtual {0} {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKColumn.NameHumanCase, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
				case Relationship.OneToMany:
					return string.Format("public virtual {0} {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKColumn.NameHumanCase, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
				case Relationship.ManyToOne:
					return string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKColumn.NameHumanCase, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
				case Relationship.ManyToMany:
					return string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKColumn.NameHumanCase, IncludeComments != CommentsStyle.None ? " // Many to many mapping" : string.Empty);
				default:
					throw new ArgumentOutOfRangeException("relationship");
			}
		}

		private string GenerateConstructorString()
		{
			switch (Relationship)
			{
				case Relationship.ManyToOne:
					return string.Format("{0} = new HashSet<{1}>();", FKColumn.NameHumanCase, FKTable.NameHumanCase);
				case Relationship.ManyToMany:
					return string.Format("{0} = new HashSet<{1}>();", FKColumn.NameHumanCase, FKTable.NameHumanCase);
				default:
					return string.Empty;
			}
		}
	}
}
