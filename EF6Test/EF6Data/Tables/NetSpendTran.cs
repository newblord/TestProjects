namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NetSpendTran
    {
        [Key]
        public int NET_SPEND_TRANS_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public short RESULT_NUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Required]
        [StringLength(100)]
        public string RESULT_STR { get; set; }

        [Required]
        [StringLength(16)]
        public string CCARD_NUM { get; set; }
    }
}
