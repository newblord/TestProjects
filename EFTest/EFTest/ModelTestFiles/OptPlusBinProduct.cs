namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusBinProduct")]
    public partial class OptPlusBinProduct
    {
        [Key]
        public int OPTPLUS_BIN_PRODUCT_KEY { get; set; }

        public int PREPAID_CARD_BIN_KEY { get; set; }

        public int OPTPLUS_PRODUCT_KEY { get; set; }

        public int? VENDOR_PRODUCT_ID { get; set; }

        public int? VENDOR_PACKAGE_ID { get; set; }

        public int? TEST_VENDOR_PRODUCT_ID { get; set; }

        public int? TEST_VENDOR_PACKAGE_ID { get; set; }

        public virtual OptPlusProduct OptPlusProduct { get; set; }

        public virtual PrepaidCardBin PrepaidCardBin { get; set; }
    }
}
