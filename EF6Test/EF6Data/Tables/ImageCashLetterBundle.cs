namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageCashLetterBundle")]
    public partial class ImageCashLetterBundle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageCashLetterBundle()
        {
            CashedChecks = new HashSet<CashedCheck>();
        }

        [Key]
        public int IMAGE_CASH_LETTER_BUNDLE_KEY { get; set; }

        public int IMAGE_CASH_LETTER_DETAIL_KEY { get; set; }

        public short BUNDLE_SEQ { get; set; }

        public int WS_RESPONSE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheck> CashedChecks { get; set; }

        public virtual ImageCashLetterDetail ImageCashLetterDetail { get; set; }
    }
}
