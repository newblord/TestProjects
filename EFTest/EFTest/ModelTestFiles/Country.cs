namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            AMLAdditionalParties = new HashSet<AMLAdditionalParty>();
            AMLForeignAddresses = new HashSet<AMLForeignAddress>();
        }

        [Key]
        public int COUNTRY_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public int? CURRENCY_KEY { get; set; }

        public bool IS_ENABLED { get; set; }

        [Required]
        [StringLength(2)]
        public string ISO_2_CHAR_COUNTRY_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLAdditionalParty> AMLAdditionalParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLForeignAddress> AMLForeignAddresses { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
