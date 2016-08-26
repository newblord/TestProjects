namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardsEdit")]
    public partial class CreditCardsEdit
    {
        [Key]
        public int CREDITCARDSEDIT_KEY { get; set; }

        public int CREDITCARD_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(120)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(120)]
        public string NEW_VALUE { get; set; }
    }
}
