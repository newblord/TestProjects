namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterResult")]
    public partial class FormLetterResult
    {
        [Key]
        public int FORM_LETTER_RESULT_KEY { get; set; }

        public int FORM_LETTER_PRINTED_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int? CUSTOMER_ADDRESS_KEY { get; set; }

        public byte FORM_LETTER_RESULT_FILE_TYPE { get; set; }

        [Required]
        [StringLength(4)]
        public string FORM_LETTER_RESULT_ERROR_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string FORM_LETTER_RESULT_FFWD_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string FORM_LETTER_RESULT_DPV_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string FORM_LETTER_RESULT_RET_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string MAILING_SVC_JOB_NUM { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }

        public virtual FormLetterBatch FormLetterBatch { get; set; }

        public virtual FormLetterPrinted FormLetterPrinted { get; set; }
    }
}
