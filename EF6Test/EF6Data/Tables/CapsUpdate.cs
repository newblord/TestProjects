namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CapsUpdate
    {
        [Key]
        public int CAPS_UPDATES_KEY { get; set; }

        [Required]
        public string SQL { get; set; }

        public bool PROCESSED { get; set; }

        public int CAPS_HOLD_KEY { get; set; }

        public int CAPS_RUN_KEY { get; set; }

        [StringLength(30)]
        public string UPDATE_TABLE { get; set; }
    }
}
