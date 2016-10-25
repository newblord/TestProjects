namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExternalAppRunDate
    {
        [Key]
        public int EXTERNAL_APPS_RUN_DATES_KEY { get; set; }

        public int EXTERNAL_APPS_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RUN_DATE { get; set; }

        public byte priority { get; set; }

        public virtual ExternalApp ExternalApp { get; set; }
    }
}
