namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeVerificationMessage")]
    public partial class IncomeVerificationMessage
    {
        [Key]
        public int INCOME_VERIFICATION_MESSAGE_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [StringLength(4000)]
        public string MESSAGE_TEXT { get; set; }
    }
}
