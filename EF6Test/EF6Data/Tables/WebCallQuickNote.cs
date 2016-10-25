namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallQuickNote")]
    public partial class WebCallQuickNote
    {
        [Key]
        public int QUICK_NOTE_KEY { get; set; }

        public short ASSIGNED_POSITION { get; set; }

        [Required]
        [StringLength(200)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(20)]
        public string BUTTON_TEXT { get; set; }

        public int BUTTON_BACKGROUND_COLOR { get; set; }

        public int BUTTON_FOREGROUND_COLOR { get; set; }
    }
}
