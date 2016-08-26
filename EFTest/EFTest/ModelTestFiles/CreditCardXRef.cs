namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardXRef")]
    public partial class CreditCardXRef
    {
        [Key]
        public int CREDITCARDXREF_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [StringLength(20)]
        public string ORIGINAL_PRN { get; set; }

        [StringLength(20)]
        public string ID_NO { get; set; }

        public byte CARD_BRAND { get; set; }

        public int? CREDIT_CARD_KEY { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
