namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CurrencyExchangeConfig")]
    public partial class CurrencyExchangeConfig
    {
        [Key]
        public int CURRENCY_EXCHANGE_CONFIG_KEY { get; set; }

        public int CURRENCY_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool MANUAL_FEE_OVERRIDE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_EXCHANGE_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_EXCHANGE_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal EXCHANGE_FEE { get; set; }

        public bool EXCHANGE_RATE_OVERRIDE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MAX_EXCHANGE_RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_EXCHANGE_RATE { get; set; }

        public bool DUAL_AUTHORIZATION { get; set; }

        public bool GOVT_ID_REQUIRED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BUY_EXCHANGE_RATE_PERCENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SELL_EXCHANGE_RATE_PERCENT { get; set; }

        public virtual Company Company { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
