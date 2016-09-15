namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerParsedCashException")]
    public partial class TellerParsedCashException
    {
        [Key]
        public int TELLER_PARSEDCASHEXCEPTION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "money")]
        public decimal TRANSACTION_AMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal ENTERED_AMOUNT { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? TRANSACTION_KEY { get; set; }
    }
}
