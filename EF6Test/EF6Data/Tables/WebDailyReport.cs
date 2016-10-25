namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDailyReport")]
    public partial class WebDailyReport
    {
        [Key]
        public int web_daily_report_key { get; set; }

        public int web_daily_report_field_key { get; set; }

        public long numeric_value { get; set; }

        public DateTime date_reported { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(4)]
        public string msa { get; set; }

        [StringLength(500)]
        public string source { get; set; }
    }
}
