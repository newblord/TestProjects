namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FcrmAmlTransCode")]
    public partial class FcrmAmlTransCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FcrmAmlTransCode()
        {
            AMLThresholdRuleTransXrefs = new HashSet<AMLThresholdRuleTransXref>();
            FcrmAmlCheckTypeXrefs = new HashSet<FcrmAmlCheckTypeXref>();
            FcrmAmlServiceXRefs = new HashSet<FcrmAmlServiceXRef>();
            FcrmAmlTransCodeXRefs = new HashSet<FcrmAmlTransCodeXRef>();
        }

        [Key]
        public int FCRM_AML_TRANS_CODE_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool DUPLICATE_CASH_RECORD { get; set; }

        public bool IS_ENABLED { get; set; }

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
        public virtual ICollection<AMLThresholdRuleTransXref> AMLThresholdRuleTransXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FcrmAmlCheckTypeXref> FcrmAmlCheckTypeXrefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FcrmAmlServiceXRef> FcrmAmlServiceXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FcrmAmlTransCodeXRef> FcrmAmlTransCodeXRefs { get; set; }
    }
}
