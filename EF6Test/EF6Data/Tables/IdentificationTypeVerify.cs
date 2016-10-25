namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationTypeVerify")]
    public partial class IdentificationTypeVerify
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IdentificationTypeVerify()
        {
            CustomerIdentifications = new HashSet<CustomerIdentification>();
            LoanApplications = new HashSet<LoanApplication>();
        }

        [Required]
        [StringLength(1)]
        public string VERIFY_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string ID_VERIFY_DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        public int IDENTIFICATION_TYPE_VERIFY_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIdentification> CustomerIdentifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
