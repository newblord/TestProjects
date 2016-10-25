namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebDailyReportState
    {
        [Key]
        public int web_daily_report_State_key { get; set; }

        [Required]
        [StringLength(50)]
        public string state { get; set; }

        public int State_Sort_Priority { get; set; }

        public bool Disabled { get; set; }
    }
}
