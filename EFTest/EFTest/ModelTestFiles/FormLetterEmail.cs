namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterEmail")]
    public partial class FormLetterEmail
    {
        [Key]
        public int FORM_LETTER_EMAIL_KEY { get; set; }

        public bool IS_ADASTRA { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ADDRESS { get; set; }
    }
}
