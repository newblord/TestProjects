using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetail
    {
        public TransDetail()
        {
            AmladditionalParty = new HashSet<AmladditionalParty>();
            Amloccupation = new HashSet<Amloccupation>();
            CashedCheck = new HashSet<CashedCheck>();
            CashedCheckPaymentRefund = new HashSet<CashedCheckPaymentRefund>();
            CourtesyPayout = new HashSet<CourtesyPayout>();
            CpiuDetail = new HashSet<CpiuDetail>();
            CreditCardTrans = new HashSet<CreditCardTrans>();
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTrans>();
            DcardChargeBackXrefRefundTransDetailKeyNavigation = new HashSet<DcardChargeBackXref>();
            DcardChargeBackXrefRefundedTransDetailKeyNavigation = new HashSet<DcardChargeBackXref>();
            DepositBag = new HashSet<DepositBag>();
            Doc10000TransDetail = new HashSet<Doc10000TransDetail>();
            EarnedCreditTrans = new HashSet<EarnedCreditTrans>();
            InsurancePayment = new HashSet<InsurancePayment>();
            Loan = new HashSet<Loan>();
            LoanFunding = new HashSet<LoanFunding>();
            LoanPayment = new HashSet<LoanPayment>();
            OpenEndLoanStatement = new HashSet<OpenEndLoanStatement>();
            OverShort = new HashSet<OverShort>();
            PayStub = new HashSet<PayStub>();
            PromiseToPayDetailTrans = new HashSet<PromiseToPayDetailTrans>();
            PurchaseService = new HashSet<PurchaseService>();
            ScannedDocument = new HashSet<ScannedDocument>();
            TransDetailAcct = new HashSet<TransDetailAcct>();
            TransDetailCash = new HashSet<TransDetailCash>();
            TransDetailCheck = new HashSet<TransDetailCheck>();
            TransDetailLoan = new HashSet<TransDetailLoan>();
            TransDetailService = new HashSet<TransDetailService>();
            TransferFunds = new HashSet<TransferFunds>();
            VaultCount = new HashSet<VaultCount>();
            WebLoanCreditFraud = new HashSet<WebLoanCreditFraud>();
        }

        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public int? TransPosKey { get; set; }
        public int? DrawerzKey { get; set; }
        public int? ReverseKey { get; set; }
        public int? CustomerKey { get; set; }
        public byte TransCode { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }

        public virtual ICollection<AmladditionalParty> AmladditionalParty { get; set; }
        public virtual ICollection<Amloccupation> Amloccupation { get; set; }
        public virtual ICollection<CashedCheck> CashedCheck { get; set; }
        public virtual ICollection<CashedCheckPaymentRefund> CashedCheckPaymentRefund { get; set; }
        public virtual ICollection<CourtesyPayout> CourtesyPayout { get; set; }
        public virtual ICollection<CpiuDetail> CpiuDetail { get; set; }
        public virtual ICollection<CreditCardTrans> CreditCardTrans { get; set; }
        public virtual ICollection<CurrencyExchangeTrans> CurrencyExchangeTrans { get; set; }
        public virtual ICollection<DcardChargeBackXref> DcardChargeBackXrefRefundTransDetailKeyNavigation { get; set; }
        public virtual ICollection<DcardChargeBackXref> DcardChargeBackXrefRefundedTransDetailKeyNavigation { get; set; }
        public virtual ICollection<DepositBag> DepositBag { get; set; }
        public virtual ICollection<Doc10000TransDetail> Doc10000TransDetail { get; set; }
        public virtual ICollection<EarnedCreditTrans> EarnedCreditTrans { get; set; }
        public virtual ICollection<InsurancePayment> InsurancePayment { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<LoanFunding> LoanFunding { get; set; }
        public virtual ICollection<LoanPayment> LoanPayment { get; set; }
        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatement { get; set; }
        public virtual ICollection<OverShort> OverShort { get; set; }
        public virtual ICollection<PayStub> PayStub { get; set; }
        public virtual ICollection<PromiseToPayDetailTrans> PromiseToPayDetailTrans { get; set; }
        public virtual ICollection<PurchaseService> PurchaseService { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual ICollection<ScannedDocument> ScannedDocument { get; set; }
        public virtual ICollection<TransDetailAcct> TransDetailAcct { get; set; }
        public virtual ICollection<TransDetailCash> TransDetailCash { get; set; }
        public virtual ICollection<TransDetailCheck> TransDetailCheck { get; set; }
        public virtual ICollection<TransDetailLoan> TransDetailLoan { get; set; }
        public virtual ICollection<TransDetailService> TransDetailService { get; set; }
        public virtual ICollection<TransferFunds> TransferFunds { get; set; }
        public virtual ICollection<VaultCount> VaultCount { get; set; }
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFraud { get; set; }
        public virtual DrawerZ DrawerzKeyNavigation { get; set; }
        public virtual TransDetail ReverseKeyNavigation { get; set; }
        public virtual ICollection<TransDetail> InverseReverseKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
        public virtual TransPos TransPosKeyNavigation { get; set; }
    }
}
