namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InsuranceClaimStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceClaimStatu()
        {
            InsuranceClaimEdits = new HashSet<InsuranceClaimEdit>();
        }

        [Key]
        public int INSURANCE_CLAIM_STATUS_KEY { get; set; }

        public int INSURANCE_CLAIM_KEY { get; set; }

        public int INSURANCE_STATUS_KEY { get; set; }

        [Required]
        [StringLength(2000)]
        public string CLAIM_STATUS_NOTE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FOLLOW_UP_DATE { get; set; }

        public virtual InsuranceClaim InsuranceClaim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaimEdit> InsuranceClaimEdits { get; set; }

        public virtual InsuranceStatu InsuranceStatu { get; set; }
    }
}
