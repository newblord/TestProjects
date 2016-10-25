namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xtp")]
    public partial class Xtp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tpkey { get; set; }

        public int? ckey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_POS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal CASH_RECV { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smallmoney")]
        public decimal CASH_PAID { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal CCARD_RECV { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal CCARD_PAID { get; set; }
    }
}
