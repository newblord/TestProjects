namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseService")]
    public partial class PurchaseService
    {
        [Key]
        public int PURCHASE_SERVICE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public int? GL_ACCT { get; set; }

        public byte PAYMENT_FROM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_COST { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(16)]
        public string OPTPLUS_CARD_FIRST { get; set; }

        [Required]
        [StringLength(16)]
        public string OPTPLUS_CARD_LAST { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
