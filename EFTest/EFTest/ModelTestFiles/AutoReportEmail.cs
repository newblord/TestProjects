namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoReportEmail")]
    public partial class AutoReportEmail
    {
        [Key]
        public int AUTO_REPORT_EMAIL_KEY { get; set; }

        public int AUTO_REPORT_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ADDRESS { get; set; }

        public virtual AutoReport AutoReport { get; set; }
    }
}
