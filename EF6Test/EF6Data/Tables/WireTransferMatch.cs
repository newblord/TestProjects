namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WireTransferMatch")]
    public partial class WireTransferMatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WireTransferMatch()
        {
            WireTransferMatchEdits = new HashSet<WireTransferMatchEdit>();
        }

        [Key]
        public int WIRE_TRANSFER_MATCH_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool IS_MATCHED { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public short? LOCATION { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? SERVICE_TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPDATED_DATE { get; set; }

        public bool MATCHED_BY_BATCH { get; set; }

        [Required]
        [StringLength(100)]
        public string BATCH_NAME { get; set; }

        [Required]
        [StringLength(15)]
        public string WIRE_TRANSFER_RECEIPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TRANSACTION_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PRINCIPAL_AMOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? FEE_AMOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COMMISSION_AMOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOTAL_AMOUNT { get; set; }

        public bool SENDER { get; set; }

        public bool RECEIVER { get; set; }

        [Required]
        [StringLength(30)]
        public string SENDER_FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string SENDER_LAST_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string SENDER_MIDDLE_INITIAL { get; set; }

        [Required]
        [StringLength(85)]
        public string SENDER_FULL_NAME { get; set; }

        [Required]
        [StringLength(75)]
        public string SENDER_STREET { get; set; }

        [Required]
        [StringLength(35)]
        public string SENDER_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string SENDER_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string SENDER_ZIP_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string SENDER_COUNTRY_CODE_2_CHAR { get; set; }

        [Required]
        [StringLength(3)]
        public string SENDER_COUNTRY_CODE_3_CHAR { get; set; }

        [Required]
        [StringLength(20)]
        public string SENDER_PHONE { get; set; }

        [Required]
        [StringLength(9)]
        public string SENDER_TAX_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SENDER_ID_TYPE { get; set; }

        [Required]
        [StringLength(25)]
        public string SENDER_ID_NUMBER { get; set; }

        [Required]
        [StringLength(50)]
        public string SENDER_ID_AUTHORITY { get; set; }

        [Required]
        [StringLength(10)]
        public string SENDER_DOB { get; set; }

        [Required]
        [StringLength(30)]
        public string RECEIVER_FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string RECEIVER_LAST_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string RECEIVER_MIDDLE_INITIAL { get; set; }

        [Required]
        [StringLength(85)]
        public string RECEIVER_FULL_NAME { get; set; }

        [Required]
        [StringLength(75)]
        public string RECEIVER_STREET { get; set; }

        [Required]
        [StringLength(35)]
        public string RECEIVER_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string RECEIVER_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string RECEIVER_ZIP_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string RECEIVER_COUNTRY_CODE_2_CHAR { get; set; }

        [Required]
        [StringLength(3)]
        public string RECEIVER_COUNTRY_CODE_3_CHAR { get; set; }

        [Required]
        [StringLength(20)]
        public string RECEIVER_PHONE { get; set; }

        [Required]
        [StringLength(9)]
        public string RECEIVER_TAX_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RECEIVER_ID_TYPE { get; set; }

        [Required]
        [StringLength(25)]
        public string RECEIVER_ID_NUMBER { get; set; }

        [Required]
        [StringLength(50)]
        public string RECEIVER_ID_AUTHORITY { get; set; }

        [Required]
        [StringLength(10)]
        public string RECEIVER_DOB { get; set; }

        public int? RUN_MASTER_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WireTransferMatchEdit> WireTransferMatchEdits { get; set; }
    }
}
