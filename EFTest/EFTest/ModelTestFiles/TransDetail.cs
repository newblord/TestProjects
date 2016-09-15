namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetail")]
    public partial class TransDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransDetail()
        {
            AMLAdditionalParties = new HashSet<AMLAdditionalParty>();
            AMLOccupations = new HashSet<AMLOccupation>();
            CashedChecks = new HashSet<CashedCheck>();
            CashedCheckPaymentRefunds = new HashSet<CashedCheckPaymentRefund>();
            CourtesyPayouts = new HashSet<CourtesyPayout>();
            CpiuDetails = new HashSet<CpiuDetail>();
            CreditCardTrans = new HashSet<CreditCardTran>();
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTran>();
            DCardChargeBackXRefs = new HashSet<DCardChargeBackXRef>();
            DCardChargeBackXRefs1 = new HashSet<DCardChargeBackXRef>();
            DepositBags = new HashSet<DepositBag>();
            Doc10000TransDetail = new HashSet<Doc10000TransDetail>();
            EarnedCreditTrans = new HashSet<EarnedCreditTran>();
            InsurancePayments = new HashSet<InsurancePayment>();
            Loans = new HashSet<Loan>();
            LoanFundings = new HashSet<LoanFunding>();
            LoanPayments = new HashSet<LoanPayment>();
            OpenEndLoanStatements = new HashSet<OpenEndLoanStatement>();
            OverShorts = new HashSet<OverShort>();
            PayStubs = new HashSet<PayStub>();
            PromiseToPayDetailTrans = new HashSet<PromiseToPayDetailTran>();
            PurchaseServices = new HashSet<PurchaseService>();
            Receipts = new HashSet<Receipt>();
            ScannedDocuments = new HashSet<ScannedDocument>();
            TransDetail1 = new HashSet<TransDetail>();
            TransDetailAccts = new HashSet<TransDetailAcct>();
            TransDetailCashes = new HashSet<TransDetailCash>();
            TransDetailChecks = new HashSet<TransDetailCheck>();
            TransDetailLoans = new HashSet<TransDetailLoan>();
            TransDetailServices = new HashSet<TransDetailService>();
            TransferFunds = new HashSet<TransferFund>();
            VaultCounts = new HashSet<VaultCount>();
            WebLoanCreditFrauds = new HashSet<WebLoanCreditFraud>();
        }

        [Key]
        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public int? TRANS_POS_KEY { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        public int? REVERSE_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public byte TRANS_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLAdditionalParty> AMLAdditionalParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLOccupation> AMLOccupations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheck> CashedChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefund> CashedCheckPaymentRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourtesyPayout> CourtesyPayouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuDetail> CpiuDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardTran> CreditCardTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyExchangeTran> CurrencyExchangeTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DCardChargeBackXRef> DCardChargeBackXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DCardChargeBackXRef> DCardChargeBackXRefs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBag> DepositBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doc10000TransDetail> Doc10000TransDetail { get; set; }

        public virtual DrawerZ DrawerZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarnedCreditTran> EarnedCreditTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePayment> InsurancePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanFunding> LoanFundings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPayment> LoanPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OverShort> OverShorts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayStub> PayStubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPayDetailTran> PromiseToPayDetailTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseService> PurchaseServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedDocument> ScannedDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetail> TransDetail1 { get; set; }

        public virtual TransDetail TransDetail2 { get; set; }

        public virtual TransPOS TransPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailAcct> TransDetailAccts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCash> TransDetailCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCheck> TransDetailChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailLoan> TransDetailLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailService> TransDetailServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFund> TransferFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCount> VaultCounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFrauds { get; set; }
    }
}
