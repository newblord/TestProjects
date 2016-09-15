namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RuleDef")]
    public partial class RuleDef
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuleDef()
        {
            LoanDepositOrderHistories = new HashSet<LoanDepositOrderHistory>();
            RuleDefEdits = new HashSet<RuleDefEdit>();
            RuleDefSetDetails = new HashSet<RuleDefSetDetail>();
        }

        [Key]
        public int RULE_DEF_KEY { get; set; }

        public int RULE_DEF_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string DISPLAY_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [Required]
        public string CONTENT { get; set; }

        public bool IS_DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

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
        public virtual ICollection<LoanDepositOrderHistory> LoanDepositOrderHistories { get; set; }

        public virtual RuleDefType RuleDefType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleDefEdit> RuleDefEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleDefSetDetail> RuleDefSetDetails { get; set; }
    }
}
