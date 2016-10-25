namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CreditCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CreditCard()
        {
            CreditCardXRefs = new HashSet<CreditCardXRef>();
            Loans = new HashSet<Loan>();
            MPayLoans = new HashSet<MPayLoan>();
            OptPlusCardDetails = new HashSet<OptPlusCardDetail>();
            OptPlusCardDetails1 = new HashSet<OptPlusCardDetail>();
            PrepaidCardStopPayments = new HashSet<PrepaidCardStopPayment>();
            RolloverRequests = new HashSet<RolloverRequest>();
        }

        [Key]
        public int CreditCard_Key { get; set; }

        public int Customer_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string NameOnCard { get; set; }

        [StringLength(19)]
        public string CardNum { get; set; }

        public byte ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LASTUPDATE { get; set; }

        public bool CC_STATUS { get; set; }

        public bool DELETED { get; set; }

        [StringLength(255)]
        public string LastResult { get; set; }

        public bool Expired { get; set; }

        public bool CvvInvalid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool PINLESS_ELIGIBLE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RICC_EFF_DATE { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        public byte CARD_BRAND { get; set; }

        public byte CARD_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string BILLING_ADDRESS1 { get; set; }

        [Required]
        [StringLength(30)]
        public string BILLING_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string BILLING_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string BILLING_ZIPCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string BILLING_COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string BILLING_COUNTRY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(40)]
        public string BILLING_ADDR_STREET { get; set; }

        [Required]
        [StringLength(50)]
        public string BILLING_FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BILLING_BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string BILLING_BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string BILLING_ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string BILLING_ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string BILLING_ADDRESS_LINE_3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string BILLING_ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string BILLING_ADDRESS_LINE_2 { get; set; }

        [StringLength(50)]
        public string ALIAS_ID { get; set; }

        public bool MAESTRO_SWITCH { get; set; }

        public bool ELECTRON { get; set; }

        public bool PROCESSOR_FLAGGED_CREDIT { get; set; }

        [StringLength(117)]
        public string MAG_STRIP { get; set; }

        [StringLength(4)]
        public string CCV { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardXRef> CreditCardXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPayLoan> MPayLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardStopPayment> PrepaidCardStopPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolloverRequest> RolloverRequests { get; set; }
    }
}
