namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusCardDetail")]
    public partial class OptPlusCardDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusCardDetail()
        {
            FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            OptPlusCardDetail1 = new HashSet<OptPlusCardDetail>();
            OptPlusCardRIPayments = new HashSet<OptPlusCardRIPayment>();
            RISREPTs = new HashSet<RISREPT>();
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
        }

        [Key]
        public int OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public int CREDIT_CARD_KEY { get; set; }

        public int OPTPLUS_PRODUCT_KEY { get; set; }

        public bool OVERDRAFT_OPTED_IN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OVERDRAFT_AMOUNT { get; set; }

        public bool IS_ELIGIBLE_COLL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? ISSUER_KEY { get; set; }

        public int? OTHER_CREDITCARD_KEY { get; set; }

        [StringLength(30)]
        public string CARD_ID { get; set; }

        public bool? IS_DEACTIVATED { get; set; }

        public int? OPTPLUS_PREVIOUS_PRODUCT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_COLL_ACH_SENT { get; set; }

        public int? PERSON_ID { get; set; }

        [StringLength(20)]
        public string PAN_PROXY_NUM { get; set; }

        public int? PARENT_OPT_PLUS_CARD_DETAIL_KEY { get; set; }

        public bool IS_EMBOSSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRODUCT_FLIP_DATE { get; set; }

        [StringLength(13)]
        public string BANK_ACCESS_NUMBER { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual CreditCard CreditCard1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        public virtual Issuer Issuer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetail1 { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail2 { get; set; }

        public virtual OptPlusProduct OptPlusProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardRIPayment> OptPlusCardRIPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }
    }
}
