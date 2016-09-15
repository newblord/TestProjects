namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TotalDailyFee
    {
        [Key]
        public int TOTAL_DAILY_FEES_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_PAYDAY { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_TITLE { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_SIG { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_CASH_CHK { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_OTHER { get; set; }

        [Column(TypeName = "money")]
        public decimal INTERNET_FEES { get; set; }

        [Column(TypeName = "money")]
        public decimal STORE_FEES_TOTAL { get; set; }

        public short STORE_FEES_RANK { get; set; }

        [Column(TypeName = "money")]
        public decimal ALL_FEES_TOTAL { get; set; }

        public short ALL_FEES_RANK { get; set; }
    }
}
