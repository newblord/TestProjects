namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusCardRIPayment")]
    public partial class OptPlusCardRIPayment
    {
        [Key]
        public int OPTPLUS_CARD_RI_PAYMENT_KEY { get; set; }

        public int OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(500)]
        public string NOTE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        public bool REVERSED { get; set; }

        public DateTime? REVERSED_DATE { get; set; }

        public short PAYMENT_METHOD { get; set; }

        public byte TRANS_CODE { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
