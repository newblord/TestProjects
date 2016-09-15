namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OOWSessionQuestion")]
    public partial class OOWSessionQuestion
    {
        [Key]
        public int OOW_SESSION_QUESTION_KEY { get; set; }

        public int OOW_SESSION_KEY { get; set; }

        public int QUESTION_ID { get; set; }

        public int? TYPE { get; set; }

        public int? TIME_PERMITTED_SECONDS { get; set; }

        public int? ACTUAL_TIME_SECONDS { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual OOWSession OOWSession { get; set; }
    }
}
