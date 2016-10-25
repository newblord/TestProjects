namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldDailyBagDetail")]
    public partial class GoldDailyBagDetail
    {
        [Key]
        public int GOLD_DAILY_BAG_DETAIL_KEY { get; set; }

        public int GOLD_DAILY_BAG_KEY { get; set; }

        public int GOLD_TRANS_KEY { get; set; }

        public virtual GoldDailyBag GoldDailyBag { get; set; }
    }
}
