namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDI")]
    public partial class DDI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDI()
        {
            DDIACHHistories = new HashSet<DDIACHHistory>();
            DDIEditHistories = new HashSet<DDIEditHistory>();
            DDISendDetails = new HashSet<DDISendDetail>();
            DDISendQueues = new HashSet<DDISendQueue>();
        }

        [Key]
        public int DDI_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(18)]
        public string REFERENCE { get; set; }

        public int STATUS_CODE { get; set; }

        public DateTime STATUS_CHANGED_DATE { get; set; }

        public DateTime ENTERED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? RE_SUBMISSION_EMAIL_SENT_DATE { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDIACHHistory> DDIACHHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDIEditHistory> DDIEditHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDISendDetail> DDISendDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDISendQueue> DDISendQueues { get; set; }
    }
}
