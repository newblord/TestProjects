namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForceApprovalValue")]
    public partial class ForceApprovalValue
    {
        [Key]
        public int FORCE_APPROVAL_VALUE_KEY { get; set; }

        public int FORCE_APPROVAL_QUESTION_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string VALUE { get; set; }

        public bool BANK_STATEMENT_SUPPLIED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }
    }
}
