namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FormLetterBatchStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormLetterBatchStatu()
        {
            FormLetterBatches = new HashSet<FormLetterBatch>();
        }

        [Key]
        public byte FORM_LETTER_BATCH_STATUS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS_DESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterBatch> FormLetterBatches { get; set; }
    }
}
