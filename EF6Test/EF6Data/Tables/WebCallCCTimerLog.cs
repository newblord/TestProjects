namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCCTimerLog")]
    public partial class WebCallCCTimerLog
    {
        [Key]
        public int CALL_CENTER_TIMER_LOG_KEY { get; set; }

        [StringLength(50)]
        public string CALLED_METHOD_NAME { get; set; }

        [StringLength(500)]
        public string CALLED_FROM_NAME { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(5)]
        public string TIME_STAMP_TYPE { get; set; }

        public DateTime? TIME_STAMP { get; set; }
    }
}
