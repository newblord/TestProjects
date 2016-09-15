namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForceApprovalQuestion")]
    public partial class ForceApprovalQuestion
    {
        [Key]
        public int FORCE_APPROVAL_QUESTION_KEY { get; set; }

        public int QUESTION_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string QUESTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_STATEMENT_RELATED { get; set; }
    }
}
