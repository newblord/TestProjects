namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterBatchBuildLetterProgress")]
    public partial class FormLetterBatchBuildLetterProgress
    {
        [Key]
        public int FORM_LETTER_BATCH_BUILD_LETTER_PROGRESS_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int FORM_LETTER_KEY { get; set; }

        public bool BUILD_COMPLETE { get; set; }
    }
}
