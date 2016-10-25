namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardResultCode")]
    public partial class CreditCardResultCode
    {
        [Key]
        public short CREDIT_CARD_RESULT_CODE_KEY { get; set; }

        [Required]
        [StringLength(5)]
        public string RESULT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string RESULT_TEXT { get; set; }

        public bool MARK_CARD_INVALID { get; set; }

        public bool BLOCK_CARD { get; set; }

        public bool IS_APPROVED { get; set; }

        public bool IS_SYSTEM_ERROR { get; set; }

        public bool MARK_CARD_EXPIRED { get; set; }

        public bool CAN_SECURE_INTERNET_LOAN { get; set; }

        public bool CAN_SECURE_STORE_LOAN { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public bool IS_AV_APPROVED { get; set; }

        public byte? CREDIT_CARD_VENDOR_KEY { get; set; }

        [StringLength(500)]
        public string RESULT_DESCRIPTION { get; set; }

        public byte? RESULT_CODE_TYPE_ID { get; set; }

        public bool MARK_CREDIT_CARD { get; set; }

        public virtual CreditCardVendor CreditCardVendor { get; set; }
    }
}
