namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferralMethod")]
    public partial class ReferralMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferralMethod()
        {
            Customers = new HashSet<Customer>();
            LoanApplications = new HashSet<LoanApplication>();
        }

        [Key]
        public short REFERRAL_METHOD_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string REFERRAL_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REFERRAL_DESC { get; set; }

        public short CURO_ORDER { get; set; }

        public short WEB_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
