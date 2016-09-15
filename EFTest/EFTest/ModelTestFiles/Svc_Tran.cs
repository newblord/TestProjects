namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Svc_Tran
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime trx_date { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string trx_teller { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short trx_location { get; set; }

        [StringLength(9)]
        public string trx_ss_no { get; set; }

        [StringLength(25)]
        public string trx_lastname { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte trx_svc { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short trxQtySold { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal svc_amount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int svc_extra { get; set; }

        public int? trx_no { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal trx_fee { get; set; }

        public int? trx_tax { get; set; }

        public int? trx_glacct { get; set; }

        public int? trx_glacct_amt { get; set; }

        public int? trx_glacct_fee { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool trx_void { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? voidDate { get; set; }

        public int? trx_cash { get; set; }

        public int? trx_clrd { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? AcctNo { get; set; }

        public int? Num { get; set; }

        public int? xtime { get; set; }

        public int? ztime { get; set; }

        public int? btime { get; set; }

        public int? ID_NO { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int svc_tran_key { get; set; }

        public int? LoyDiscAmt { get; set; }

        public int? LoyDiscPts { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }
    }
}
