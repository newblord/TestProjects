namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceTransDetail")]
    public partial class ServiceTransDetail
    {
        [Key]
        public int SERVICE_TRANS_DETAIL_KEY { get; set; }

        public int SERVICE_TRANS_KEY { get; set; }

        [StringLength(50)]
        public string PERSON_RECEIVED { get; set; }

        [StringLength(50)]
        public string COUNTRY_TO { get; set; }

        [StringLength(50)]
        public string OCCUPATION { get; set; }

        [StringLength(50)]
        public string PURPOSE { get; set; }

        [Required]
        [StringLength(30)]
        public string BILLER_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string BILLPAY_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string BILLPAY_ACCOUNT_NUM { get; set; }

        public bool EXPORTED { get; set; }

        public bool? IS_DOMESTIC { get; set; }

        [StringLength(500)]
        public string THIRD_PARTY_DETAILS { get; set; }

        public byte? VENDOR_ID { get; set; }

        [StringLength(15)]
        public string WIRE_TRANSFER_RECEIPT { get; set; }

        public virtual ServiceTran ServiceTran { get; set; }
    }
}
