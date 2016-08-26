namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHPresentmentType")]
    public partial class ACHPresentmentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHPresentmentType()
        {
            ACHPresentments = new HashSet<ACHPresentment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACH_PRESENTMENT_TYPE_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(3)]
        public string CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHPresentment> ACHPresentments { get; set; }
    }
}
