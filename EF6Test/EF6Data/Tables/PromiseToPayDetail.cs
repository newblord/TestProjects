namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromiseToPayDetail")]
    public partial class PromiseToPayDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PromiseToPayDetail()
        {
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            PromiseToPayDetailEdits = new HashSet<PromiseToPayDetailEdit>();
            PromiseToPayDetailTrans = new HashSet<PromiseToPayDetailTran>();
        }

        [Key]
        public int PTP_DETAIL_KEY { get; set; }

        public int PTP_PROMISE_KEY { get; set; }

        public byte PTP_METHOD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PTP_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PTP_CURR_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PTP_DUE_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string PTP_STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PTP_PAID_DATE { get; set; }

        [StringLength(19)]
        public string PTP_CC_NUMBER { get; set; }

        public short PTP_CC_EXP_YEAR { get; set; }

        public byte? PTP_CC_EXP_MONTH { get; set; }

        [StringLength(50)]
        public string PTP_CC_NAME_ON_CARD { get; set; }

        [StringLength(4)]
        public string PTP_CC_CCV { get; set; }

        [StringLength(9)]
        public string PTP_BANK_ID { get; set; }

        [StringLength(20)]
        public string PTP_ACCT_NO { get; set; }

        [StringLength(30)]
        public string PTP_NAME_ON_ACCOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PTP_PAID_AMT { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string PTP_CC_BILLING_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string PTP_CC_BILLING_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string PTP_CC_BILLING_ZIPCODE { get; set; }

        public byte PTP_CC_TIME_SLOT { get; set; }

        [Required]
        [StringLength(50)]
        public string PTP_CC_BILLING_ADDRESS1 { get; set; }

        [Required]
        [StringLength(25)]
        public string PTP_CC_BILLING_COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string PTP_CC_BILLING_COUNTRY { get; set; }

        [Required]
        [StringLength(40)]
        public string PTP_TOKEN { get; set; }

        public byte PTP_CARD_BRAND { get; set; }

        public byte PTP_CARD_TYPE { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(40)]
        public string PTP_CC_BILLING_ADDR_STREET { get; set; }

        [Required]
        [StringLength(50)]
        public string PTP_CC_BILLING_FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string PTP_CC_BILLING_BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string PTP_CC_BILLING_BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string PTP_CC_BILLING_ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string PTP_CC_BILLING_ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string PTP_CC_BILLING_ADDRESS_LINE_3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string PTP_CC_BILLING_ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string PTP_CC_BILLING_ADDRESS_LINE_2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        public virtual PromiseToPay PromiseToPay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPayDetailEdit> PromiseToPayDetailEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPayDetailTran> PromiseToPayDetailTrans { get; set; }
    }
}
