namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xst")]
    public partial class Xst
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sdkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int smkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        public int? ckey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_TRANS_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? MO_STATUS_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short QTY_SOLD { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal SERVICE_FEE { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "smallmoney")]
        public decimal SERVICE_AMT { get; set; }

        public int? GL_ACCT_FEE { get; set; }

        public int? GL_ACCT_AMT { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CALC_EXTEND { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(2)]
        public string SD { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short sd_LOCATION { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool sd_ENABLED { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal sd_SERVICE_COST { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal sd_SERVICE_FEE { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal sd_MAX_CHARGE { get; set; }

        public int? sd_GL_ACCT_FEE { get; set; }

        public int? sd_GL_ACCT_AMT { get; set; }

        public int? sd_GL_ACCT_COST { get; set; }

        public int? sd_GL_ACCT_PROFIT { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(2)]
        public string SM { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string sm_SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 23)]
        public byte sm_SERVICE_NUM { get; set; }

        [Key]
        [Column(Order = 24)]
        public byte sm_DISPLAY_ORDER { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool sm_INVENTORIED { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(2)]
        public string sm_FUNCTION_AS { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool sm_REQUIRE_CUST { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool sm_PAYOUT { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool sm_QTY_PROMPT { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool sm_AMT_PROMPT { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool sm_FEE_PROMPT { get; set; }
    }
}
