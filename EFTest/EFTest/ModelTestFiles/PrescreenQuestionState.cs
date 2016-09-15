namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrescreenQuestionState")]
    public partial class PrescreenQuestionState
    {
        [Key]
        public int PRESCREEN_QUESTION_STATE_KEY { get; set; }

        public int PRESCREEN_QUESTION_KEY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE_ABBREVIATION { get; set; }

        public virtual PrescreenQuestion PrescreenQuestion { get; set; }
    }
}
