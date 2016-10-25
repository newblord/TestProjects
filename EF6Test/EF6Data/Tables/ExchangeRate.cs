namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeRate")]
    public partial class ExchangeRate
    {
        [Key]
        public int EXCHANGE_RATE_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENCY_BASE_CODE { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENCY_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CURRENCY_NAME { get; set; }

        public decimal CURRENCY_RATE { get; set; }

        public decimal CURRENCY_INVERSE_RATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UTC_TIME_STAMP { get; set; }

        public short ACCESSES_REMAINING { get; set; }

        public short ACCESSES_SO_FAR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED { get; set; }
    }
}
