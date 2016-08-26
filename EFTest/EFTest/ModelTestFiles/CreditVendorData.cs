namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditVendorData")]
    public partial class CreditVendorData
    {
        [Key]
        public int CREDIT_VENDOR_DATA_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public byte VERITEC_STATUS { get; set; }

        [Required]
        [StringLength(2)]
        public string DEF_STATE { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_AMOUNT { get; set; }

        [StringLength(4)]
        public string CLVERIFY_PAYMENT_CODE { get; set; }

        public int? CLVERIFY_PAYMENT_NUMBER { get; set; }

        public byte CLVERIFY_STATUS { get; set; }

        public byte DATAX_STATUS { get; set; }

        public int ORIGINAL_LOAN_KEY { get; set; }

        public bool IS_SENT_VERITEC { get; set; }

        public bool IS_SENT_DATAX { get; set; }

        public bool IS_SENT_CLVERIFY { get; set; }

        public string SENT_MSG { get; set; }

        public bool? IS_SENT_GENTRY { get; set; }

        public short? DAYS_LATE { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public byte? CLARITY_STATUS { get; set; }

        public bool? IS_SENT_CLARITY { get; set; }
    }
}
