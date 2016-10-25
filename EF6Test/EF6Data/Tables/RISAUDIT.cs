namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RISAUDIT")]
    public partial class RISAUDIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RISAUDIT()
        {
            FormLetters = new HashSet<FormLetter>();
            RIS = new HashSet<RI>();
            RISREPTs = new HashSet<RISREPT>();
            SkipTraceConfig_RisAudit = new HashSet<SkipTraceConfig_RisAudit>();
            SkipTraceStep_AuditCategory = new HashSet<SkipTraceStep_AuditCategory>();
            FormLetters1 = new HashSet<FormLetter>();
        }

        [StringLength(2)]
        public string AUDIT { get; set; }

        [StringLength(50)]
        public string DESC { get; set; }

        [StringLength(10)]
        public string SHORT { get; set; }

        [Key]
        public int RIS_Audit_Id { get; set; }

        public bool? Displayed { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public bool IS_IN_LEGAL_STATUS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int RIS_AUDIT_KEY { get; set; }

        public bool DIALER_EXCLUDE { get; set; }

        public bool SUSPEND_INTEREST { get; set; }

        public bool REPOSSESSION { get; set; }

        public bool BLOCK_EMAILS { get; set; }

        public bool IS_ELIGIBLE_FOR_REPO { get; set; }

        public bool BLOCK_STATEMENTS { get; set; }

        public bool? IS_PTP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RI> RIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceConfig_RisAudit> SkipTraceConfig_RisAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep_AuditCategory> SkipTraceStep_AuditCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetters1 { get; set; }
    }
}
