using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
    public class ReverseNavigation
    {
        public Relationship Relationship { get; }
        public string PKPropertyName { get; }
        public TableColumn PKColumn { get; }
        public Table FKTable { get; }
        public string FKPropertyName { get; }
        public TableColumn FKColumn { get; }
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

        public ReverseNavigation(Relationship relationship, string pkPropertyName, TableColumn pkColumn, Table fkTable, string fkPropertyName, TableColumn fkColumn, string constraint, CommentsStyle includeComments)
        {
            Relationship = relationship;
            PKPropertyName = pkPropertyName;
            PKColumn = pkColumn;
            FKTable = fkTable;
            FKPropertyName = fkPropertyName;
            FKColumn = fkColumn;
            Constriant = constraint;
            IncludeComments = includeComments;

            PropertyString = GeneratePropertyString();
            ConstructorString = GenerateConstructorString();
        }

        private string GeneratePropertyString()
        {
            switch (Relationship)
            {
                case Relationship.OneToOne:
                    return string.Format("public virtual {0} {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKPropertyName, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
                case Relationship.OneToMany:
                    return string.Format("public virtual {0} {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKPropertyName, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
                case Relationship.ManyToOne:
                    return string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKPropertyName, IncludeComments != CommentsStyle.None ? " // " + Constriant : string.Empty);
                case Relationship.ManyToMany:
                    return string.Format("public virtual System.Collections.Generic.ICollection<{0}> {1} {{ get; set; }}{2}", FKTable.NameHumanCase, FKPropertyName, IncludeComments != CommentsStyle.None ? " // Many to many mapping" : string.Empty);
                default:
                    throw new ArgumentOutOfRangeException("relationship");
            }
        }

        private string GenerateConstructorString()
        {
            switch (Relationship)
            {
                case Relationship.ManyToOne:
                    return string.Format("{0} = new HashSet<{1}>();", FKPropertyName, FKTable.NameHumanCase);
                case Relationship.ManyToMany:
                    return string.Format("{0} = new HashSet<{1}>();", FKPropertyName, FKTable.NameHumanCase);
                default:
                    return string.Empty;
            }
        }
    }
}
