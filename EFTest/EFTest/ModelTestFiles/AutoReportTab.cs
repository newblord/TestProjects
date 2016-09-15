namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoReportTab")]
    public partial class AutoReportTab
    {
        [Key]
        public int AUTO_REPORT_TAB_KEY { get; set; }

        public int AUTO_REPORT_KEY { get; set; }

        public byte RESULT_NUM { get; set; }

        [Required]
        [StringLength(30)]
        public string TAB_NAME { get; set; }

        public virtual AutoReport AutoReport { get; set; }
    }
}
