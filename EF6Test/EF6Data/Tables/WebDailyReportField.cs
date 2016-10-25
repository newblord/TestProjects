namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebDailyReportField
    {
        [Key]
        public int web_daily_report_fields_key { get; set; }

        [Required]
        [StringLength(150)]
        public string field_description { get; set; }

        [StringLength(150)]
        public string group_name { get; set; }

        public int Group_Sort_Priority { get; set; }

        public int Field_Sort_Priority { get; set; }

        public bool Disabled { get; set; }

        public bool? allow_range { get; set; }
    }
}
