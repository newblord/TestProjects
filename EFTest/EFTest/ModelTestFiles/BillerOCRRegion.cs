namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillerOCRRegion")]
    public partial class BillerOCRRegion
    {
        [Key]
        public int BILLER_OCRREGION_KEY { get; set; }

        public int BILLPAY_BILLER_KEY { get; set; }

        public int OCRREGION_KEY { get; set; }

        public int SCANLINELENGTH { get; set; }

        public byte? ACCOUNT_NUM_START { get; set; }

        public byte? ACCOUNT_NUM_LENGTH { get; set; }

        public byte? AMOUNT_START { get; set; }

        public byte? AMOUNT_LENGTH { get; set; }

        public bool? TRIM_ACCOUNT_NUM_LEADING_ZEROS { get; set; }

        public virtual BillPayBiller BillPayBiller { get; set; }

        public virtual OCRRegion OCRRegion { get; set; }
    }
}
