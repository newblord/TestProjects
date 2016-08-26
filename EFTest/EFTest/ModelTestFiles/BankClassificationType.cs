namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankClassificationType")]
    public partial class BankClassificationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankClassificationType()
        {
            BankClassifications = new HashSet<BankClassification>();
        }

        [Key]
        public int BANK_CLASSIFICATION_TYPE_KEY { get; set; }

        public int BANK_CLASSIFICATION_TYPE { get; set; }

        [Required]
        [StringLength(100)]
        public string BANK_CLASSIFICATION_DESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankClassification> BankClassifications { get; set; }
    }
}
