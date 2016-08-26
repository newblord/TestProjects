namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldTransfer")]
    public partial class GoldTransfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldTransfer()
        {
            GoldTransferDetails = new HashSet<GoldTransferDetail>();
        }

        [Key]
        public int GOLD_TRANSFER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SENT_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string SENT_BY { get; set; }

        public int? SENT_DAILY_BAG_CNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SENT_DAILY_BAG_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECV_DATE { get; set; }

        [StringLength(3)]
        public string RECV_BY { get; set; }

        public int? RECV_DAILY_BAG_CNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? RECV_DAILY_BAG_AMT { get; set; }

        [Required]
        [StringLength(30)]
        public string COURIER_TRACKING_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string COURIER_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransferDetail> GoldTransferDetails { get; set; }
    }
}
