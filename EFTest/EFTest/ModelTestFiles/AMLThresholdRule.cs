namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AMLThresholdRule")]
    public partial class AMLThresholdRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AMLThresholdRule()
        {
            AMLThresholdRuleTransXrefs = new HashSet<AMLThresholdRuleTransXref>();
        }

        [Key]
        public int AML_THRESHOLD_RULE_KEY { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool IS_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_DOLLAR_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_DOLLAR_AMT { get; set; }

        public int THRESHOLD_TYPE { get; set; }

        public bool IS_AGGREGATED { get; set; }

        public bool INCLUDE_FEES { get; set; }

        public bool REQ_AML_PRIMARY { get; set; }

        public bool REQ_AML_SECONDARY { get; set; }

        public bool REQ_AML_CTR { get; set; }

        public bool EXPIRED_ACCEPTED { get; set; }

        public bool INQUIRE_OCCUPATION { get; set; }

        public bool PROMPT_OTHER_PARTY { get; set; }

        public bool PROMPT_PURPOSE { get; set; }

        public bool REQUIRE_CUSTOMER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public bool PROMPT_OCCUPATION_EVERYDAY { get; set; }

        public bool PROMPT_OCCUPATION_EVERYTRANS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLThresholdRuleTransXref> AMLThresholdRuleTransXrefs { get; set; }
    }
}
