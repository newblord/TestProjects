namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardBrand")]
    public partial class CreditCardBrand
    {
        [Key]
        public int CREDIT_CARD_BRAND_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string BRAND_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string BRAND_DESCRIPTION { get; set; }
    }
}
