namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHBankConfig")]
    public partial class ACHBankConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHBankConfig()
        {
            ACHBankConfigExceptions = new HashSet<ACHBankConfigException>();
        }

        [Key]
        public int ACH_BANK_CONFIG_KEY { get; set; }

        public int ACH_BANK_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string KEY { get; set; }

        [StringLength(512)]
        public string DEFAULT_VALUE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHBankConfigException> ACHBankConfigExceptions { get; set; }
    }
}
