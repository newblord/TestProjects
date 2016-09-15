namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleDefSet")]
    public partial class RuleDefSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuleDefSet()
        {
            LoanProductConfigs = new HashSet<LoanProductConfig>();
            RuleDefSetDetails = new HashSet<RuleDefSetDetail>();
            RuleDefSetDetailEdits = new HashSet<RuleDefSetDetailEdit>();
        }

        [Key]
        public int RULE_DEF_SET_KEY { get; set; }

        public int RULE_DEF_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfig> LoanProductConfigs { get; set; }

        public virtual RuleDefType RuleDefType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleDefSetDetail> RuleDefSetDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleDefSetDetailEdit> RuleDefSetDetailEdits { get; set; }
    }
}
