namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageCashLetter")]
    public partial class ImageCashLetter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageCashLetter()
        {
            ImageCashLetterDetails = new HashSet<ImageCashLetterDetail>();
        }

        [Key]
        public int IMAGE_CASH_LETTER_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string ICL_FILENAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORIGINAL_SUBMISSION_AMOUNT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FILE_CREATION_DATETIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FIRST_FILE_STATUS_DATETIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FILE_PROCESSED_DATETIME { get; set; }

        [Required]
        [StringLength(20)]
        public string FILE_VALIDATION_STATUS { get; set; }

        public int CASH_LETTER_COUNT { get; set; }

        public int RECORD_COUNT { get; set; }

        public int ITEM_COUNT { get; set; }

        public int NUMBER_REJECTED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ADJUSTMENT_DOLLARS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageCashLetterDetail> ImageCashLetterDetails { get; set; }
    }
}
