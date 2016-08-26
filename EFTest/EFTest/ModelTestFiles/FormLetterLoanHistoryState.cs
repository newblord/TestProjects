namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterLoanHistoryState")]
    public partial class FormLetterLoanHistoryState
    {
        [Key]
        [StringLength(2)]
        public string FORM_LETTER_LOAN_HISTORY_STATE { get; set; }
    }
}
