namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterBatchValidation")]
    public partial class FormLetterBatchValidation
    {
        [Key]
        public int FORM_LETTER_BATCH_VALIDATION_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int FORM_LETTER_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string FORM_LETTER_NAME { get; set; }

        public int UPLOAD_COUNT { get; set; }

        public int RECEIVE_COUNT { get; set; }

        public DateTime DATE_TIME_ENTERED { get; set; }
    }
}
