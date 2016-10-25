namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromiseToPayTimeSlotConfig")]
    public partial class PromiseToPayTimeSlotConfig
    {
        [Key]
        public byte PTP_CC_TIME_SLOT { get; set; }

        public byte PTP_RUN_TIME { get; set; }

        [Required]
        [StringLength(30)]
        public string PTP_TIMESLOT_DESC { get; set; }
    }
}
