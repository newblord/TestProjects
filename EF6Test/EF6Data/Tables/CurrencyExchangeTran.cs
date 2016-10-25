namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CurrencyExchangeTran
    {
        [Key]
        public int CURRENCY_EXCHANGE_TRANS_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int TRANS_POS_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string FROM_CURRENCY_CODE { get; set; }

        public decimal FROM_CURRENCY_RATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TO_CURRENCY_CODE { get; set; }

        public decimal TO_CURRENCY_RATE { get; set; }

        [Required]
        [StringLength(3)]
        public string BASE_CURRENCY_CODE { get; set; }

        public decimal BASE_CURRENCY_RATE { get; set; }

        public decimal? CONVERSION_RATE { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT_RECEIVED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEE { get; set; }

        [Column(TypeName = "money")]
        public decimal EXCHANGE_AMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHANGE_DUE { get; set; }

        [Column(TypeName = "money")]
        public decimal PAY_BILL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAY_CHANGE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public decimal? CALCULATED_CONVERSION_RATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? FEE_IN_BASE { get; set; }

        public decimal? EXCHANGE_RATE_PERCENT { get; set; }

        public decimal? XE_CONVERSION_RATE { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? GAIN_LOSS { get; set; }

        public virtual Company Company { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual TransPOS TransPOS { get; set; }
    }
}
