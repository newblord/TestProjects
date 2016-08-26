namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationTypeAML")]
    public partial class IdentificationTypeAML
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IdentificationTypeAML()
        {
            IdentificationTypes = new HashSet<IdentificationType>();
        }

        [Key]
        public byte IDENTIFICATION_TYPE_AML_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IdentificationType> IdentificationTypes { get; set; }
    }
}
