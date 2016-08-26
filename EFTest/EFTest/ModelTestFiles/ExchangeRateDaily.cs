namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeRateDaily")]
    public partial class ExchangeRateDaily
    {
        [Key]
        public int EXCHANGE_RATE_DAILY_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime EXCHANGE_RATE_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENCY_CODE { get; set; }

        [Required]
        [StringLength(3)]
        public string BASE_CURRENCY_CODE { get; set; }

        public decimal RATE { get; set; }
    }
}
