namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillPayVendor")]
    public partial class BillPayVendor
    {
        [Key]
        public int BILLPAY_VENDOR_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string VENDOR_NAME { get; set; }

        public byte VENDOR_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string PHONE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }
    }
}
