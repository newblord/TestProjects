namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerService")]
    public partial class DrawerService
    {
        [Key]
        public int DRAWER_SERVICE_KEY { get; set; }

        public int DRAWER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int DRAWER_QTY { get; set; }

        public virtual DrawerMaster DrawerMaster { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
