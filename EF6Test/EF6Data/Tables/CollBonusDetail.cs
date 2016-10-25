namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollBonusDetail")]
    public partial class CollBonusDetail
    {
        [StringLength(3)]
        public string tellerid { get; set; }

        public int? location { get; set; }

        public long? rikey { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? rdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? pdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cdate { get; set; }

        public byte? timeframe { get; set; }

        public decimal? creditamt { get; set; }

        public byte? product { get; set; }

        public byte? paytype { get; set; }

        public bool? fec_bec { get; set; }

        public int? riage { get; set; }

        public byte? task { get; set; }

        [StringLength(20)]
        public string reference { get; set; }

        [Key]
        public int COLL_BONUS_DETAIL_KEY { get; set; }
    }
}
