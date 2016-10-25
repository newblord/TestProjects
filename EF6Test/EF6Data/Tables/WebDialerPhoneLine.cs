namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerPhoneLine")]
    public partial class WebDialerPhoneLine
    {
        [Key]
        public int WEB_DIALER_PHONE_LINE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public int LINE_NO { get; set; }

        public int COLOR_RGB { get; set; }

        public bool ENABLED { get; set; }

        [StringLength(15)]
        public string PHONE { get; set; }
    }
}
