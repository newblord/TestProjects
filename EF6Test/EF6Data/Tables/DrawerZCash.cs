namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerZCash")]
    public partial class DrawerZCash
    {
        [Key]
        public int DRAWERZ_CASH_KEY { get; set; }

        public int DRAWERZ_KEY { get; set; }

        public int CURRENCY_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal ENTERED_AMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal CALCULATED_AMOUNT { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual DrawerZ DrawerZ { get; set; }
    }
}
