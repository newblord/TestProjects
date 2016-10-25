namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerIdentification")]
    public partial class CustomerIdentification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerIdentification()
        {
            CustomerIdentificationEdits = new HashSet<CustomerIdentificationEdit>();
        }

        [Key]
        public int CUSTOMER_IDENTIFICATION_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int IDENTIFICATION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string ID_NUMBER { get; set; }

        [Required]
        [StringLength(30)]
        public string ID_SOURCE { get; set; }

        [Required]
        [StringLength(3)]
        public string CUST_ID_COUNTRY { get; set; }

        [Required]
        [StringLength(2)]
        public string CUST_ID_STATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXPIRATION_DATE { get; set; }

        [Required]
        [StringLength(30)]
        public string VERIFIED_OTHER { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? IDENTIFICATION_TYPE_VERIFY_KEY { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIdentificationEdit> CustomerIdentificationEdits { get; set; }

        public virtual IdentificationType IdentificationType { get; set; }

        public virtual IdentificationTypeVerify IdentificationTypeVerify { get; set; }
    }
}
