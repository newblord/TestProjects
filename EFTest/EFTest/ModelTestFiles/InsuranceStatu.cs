namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InsuranceStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceStatu()
        {
            InsuranceClaims = new HashSet<InsuranceClaim>();
            InsuranceClaimStatus = new HashSet<InsuranceClaimStatu>();
        }

        [Key]
        public int INSURANCE_STATUS_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string SHORT_DESCRIPTION { get; set; }

        [Required]
        [StringLength(500)]
        public string FULL_DESCRIPTION { get; set; }

        public bool IS_OPEN_CLAIM { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaim> InsuranceClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceClaimStatu> InsuranceClaimStatus { get; set; }
    }
}
