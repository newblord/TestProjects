namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheck")]
    public partial class CashedCheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashedCheck()
        {
            AttorneyLoans = new HashSet<AttorneyLoan>();
            CashedCheckImages = new HashSet<CashedCheckImage>();
            CashedCheckMICRs = new HashSet<CashedCheckMICR>();
            CashedCheckPayments = new HashSet<CashedCheckPayment>();
            CourtesyPayouts = new HashSet<CourtesyPayout>();
            DepositBagDetails = new HashSet<DepositBagDetail>();
            DepositChkDetails = new HashSet<DepositChkDetail>();
            FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            RISREPTs = new HashSet<RISREPT>();
        }

        [Key]
        public int CASHED_CHECK_KEY { get; set; }

        public short LOCATION { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int? ISSUER_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECK_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHECK_AMOUNT { get; set; }

        [Required]
        [StringLength(20)]
        public string CHECK_NO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CHECK_DATE { get; set; }

        public double CC_RATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CC_TOT_FEE { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public bool BOUNCED { get; set; }

        public bool? CC_MONEY_ORDER { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        public bool? CC_FREE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CC_ORIG_RATE { get; set; }

        public byte SRC_APPROVAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CC_PCT_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CC_FLAT_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CC_DISCOUNT_AMT { get; set; }

        public bool CC_IS_POST_DATED { get; set; }

        public int DWDOCID { get; set; }

        public int CURRENCY_KEY { get; set; }

        public int? WS_RESPONSE_KEY { get; set; }

        public int? IMAGE_CASH_LETTER_BUNDLE_KEY { get; set; }

        public bool ELECTRONIC_CASHED_CHECK { get; set; }

        public bool IS_SHREDDED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyLoan> AttorneyLoans { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ImageCashLetterBundle ImageCashLetterBundle { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckImage> CashedCheckImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckMICR> CashedCheckMICRs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPayment> CashedCheckPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourtesyPayout> CourtesyPayouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBagDetail> DepositBagDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositChkDetail> DepositChkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }
    }
}
