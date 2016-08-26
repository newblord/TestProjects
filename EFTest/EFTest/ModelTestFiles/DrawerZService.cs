namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerZService")]
    public partial class DrawerZService
    {
        [Key]
        public int DRAWERZ_SERVICE_KEY { get; set; }

        public int DRAWERZ_KEY { get; set; }

        public short LOCATION { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int DRAWERZ_QTY { get; set; }

        public int CNTZ_QTY { get; set; }

        public virtual DrawerZ DrawerZ { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
