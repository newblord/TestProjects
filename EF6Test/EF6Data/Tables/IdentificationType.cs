namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationType")]
    public partial class IdentificationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IdentificationType()
        {
            CustomerIdentifications = new HashSet<CustomerIdentification>();
        }

        [Key]
        public int IDENTIFICATION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_TYPE_DESCRIPTION { get; set; }

        public byte ID_TYPE_CATEGORY { get; set; }

        public bool IS_ACTIVE { get; set; }

        public byte MAX_ALLOWED_ID_TYPE { get; set; }

        public bool GOVT_ISSUED { get; set; }

        public bool NUMBER_REQUIRED { get; set; }

        public bool COUNTRY_REQUIRED { get; set; }

        public bool STATE_REQUIRED { get; set; }

        public bool AML_PRIMARY { get; set; }

        public bool AML_SECONDARY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public byte IDENTIFICATION_TYPE_AML_KEY { get; set; }

        public bool CTR_REPORTING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIdentification> CustomerIdentifications { get; set; }

        public virtual IdentificationTypeAML IdentificationTypeAML { get; set; }
    }
}
