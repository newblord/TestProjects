namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterBatch")]
    public partial class FormLetterBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormLetterBatch()
        {
            FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            FormLetterResults = new HashSet<FormLetterResult>();
        }

        [Key]
        public int FORM_LETTER_BATCH_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BATCH_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string UPLOAD_OR_DOWNLOAD { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public byte FORM_LETTER_BATCH_STATUS_KEY { get; set; }

        public DateTime? BATCH_STATUS_DATETIME { get; set; }

        public byte? BATCH_STEP { get; set; }

        public virtual FormLetterBatchStatu FormLetterBatchStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterResult> FormLetterResults { get; set; }
    }
}
