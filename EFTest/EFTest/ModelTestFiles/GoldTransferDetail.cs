namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldTransferDetail")]
    public partial class GoldTransferDetail
    {
        [Key]
        public int GOLD_TRANSFER_DETAIL_KEY { get; set; }

        public int GOLD_TRANSFER_KEY { get; set; }

        public int GOLD_DAILY_BAG_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public virtual GoldDailyBag GoldDailyBag { get; set; }

        public virtual GoldTransfer GoldTransfer { get; set; }
    }
}
