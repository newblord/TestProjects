namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CapsRun")]
    public partial class CapsRun
    {
        [Key]
        public int CAPS_RUN_KEY { get; set; }

        public DateTime? START_TIME { get; set; }

        public DateTime? FINISH_TIME { get; set; }

        public byte CAPS_RUN_STATUS_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        public int PREV_CAPS_RUN_KEY { get; set; }

        public virtual CapsRunStatu CapsRunStatu { get; set; }
    }
}
