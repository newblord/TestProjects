namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerXService")]
    public partial class DrawerXService
    {
        [Key]
        public int DRAWERX_SERVICE_KEY { get; set; }

        public int DRAWERX_KEY { get; set; }

        public short LOCATION { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int DRAWERX_QTY { get; set; }

        public virtual DrawerX DrawerX { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
