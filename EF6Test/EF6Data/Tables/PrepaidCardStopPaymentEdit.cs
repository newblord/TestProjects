namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardStopPaymentEdit")]
    public partial class PrepaidCardStopPaymentEdit
    {
        [Key]
        public int PREPAID_CARD_STOP_PAYMENT_EDIT_KEY { get; set; }

        public int PREPAID_CARD_STOP_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(120)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(120)]
        public string NEW_VALUE { get; set; }

        public virtual PrepaidCardStopPayment PrepaidCardStopPayment { get; set; }
    }
}
