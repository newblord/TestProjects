namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Eos310
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trans_detail_key { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime date_entered { get; set; }

        public DateTime? trans_date { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime transDateTime { get; set; }

        [StringLength(7)]
        public string product_type { get; set; }

        [StringLength(9)]
        public string loan_type { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string teller { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(36)]
        public string tellername { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short location { get; set; }

        [StringLength(50)]
        public string TransType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customer_key { get; set; }

        [Column(TypeName = "money")]
        public decimal? amount { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(51)]
        public string customer { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loan_key { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal princ_amt { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "smallmoney")]
        public decimal cash_amt { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal loan_amt { get; set; }
    }
}
