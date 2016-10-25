namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrepaidCardTran
    {
        [Key]
        public int PREPAID_CARD_TRANS_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int WS_OPERATION_KEY { get; set; }

        public int WS_RESPONSE_KEY { get; set; }

        [Required]
        [StringLength(4000)]
        public string OPERATION_PARMS { get; set; }

        [Required]
        public string OPERATION_RESULTS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? CreditCard_Key { get; set; }

        [Required]
        [StringLength(255)]
        public string COMPUTER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string SERVER_NAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AMOUNT { get; set; }

        public int? PREPAID_CARD_TRANS_ACTION_KEY { get; set; }

        public short? LOCATION { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PrepaidCardTransAction PrepaidCardTransAction { get; set; }

        public virtual WSOperation WSOperation { get; set; }

        public virtual WSResponse WSResponse { get; set; }
    }
}
