namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiftCard")]
    public partial class GiftCard
    {
        [Key]
        public int GIFT_CARD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CARD_AMOUNT { get; set; }

        [Required]
        [StringLength(30)]
        public string CARD_NUMBER { get; set; }

        [Required]
        [StringLength(150)]
        public string CARD_DATA { get; set; }

        public int? LOAN_KEY { get; set; }

        public virtual Company Company { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
