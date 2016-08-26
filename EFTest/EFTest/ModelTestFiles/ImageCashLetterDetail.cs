namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageCashLetterDetail")]
    public partial class ImageCashLetterDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageCashLetterDetail()
        {
            ImageCashLetterBundles = new HashSet<ImageCashLetterBundle>();
        }

        [Key]
        public int IMAGE_CASH_LETTER_DETAIL_KEY { get; set; }

        public int IMAGE_CASH_LETTER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(25)]
        public string CASH_LETTER_STATUS { get; set; }

        public int REJECTED_ITEM_COUNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal REJECTED_DOLLARS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual Company Company { get; set; }

        public virtual ImageCashLetter ImageCashLetter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageCashLetterBundle> ImageCashLetterBundles { get; set; }
    }
}
