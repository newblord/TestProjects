namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterLoanHistoryFile")]
    public partial class FormLetterLoanHistoryFile
    {
        [Key]
        public int FORM_LETTER_LOAN_HISTORY_FILE_KEY { get; set; }

        public int FORM_LETTER_PRINTED_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        [StringLength(150)]
        public string LOAN_HISTORY_FILE_NAME { get; set; }

        [StringLength(150)]
        public string ZIP_FILE_NAME { get; set; }

        public bool UPLOADED { get; set; }
    }
}
