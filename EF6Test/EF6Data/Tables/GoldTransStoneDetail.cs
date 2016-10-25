namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldTransStoneDetail")]
    public partial class GoldTransStoneDetail
    {
        [Key]
        public int GOLD_TRANS_STONE_DETAIL_KEY { get; set; }

        public int GOLD_TRANS_DETAIL_KEY { get; set; }

        public byte STONE_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal STONE_SIZE { get; set; }

        public byte STONE_COUNT { get; set; }

        public virtual GoldTransDetail GoldTransDetail { get; set; }
    }
}
