using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheck
    {
        public CashedCheck()
        {
            AttorneyLoan = new HashSet<AttorneyLoan>();
            CashedCheckImage = new HashSet<CashedCheckImage>();
            CashedCheckMicr = new HashSet<CashedCheckMicr>();
            CashedCheckPayment = new HashSet<CashedCheckPayment>();
            CourtesyPayout = new HashSet<CourtesyPayout>();
            DepositBagDetail = new HashSet<DepositBagDetail>();
            DepositChkDetail = new HashSet<DepositChkDetail>();
            FormLetterOnDemand = new HashSet<FormLetterOnDemand>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            Risrept = new HashSet<Risrept>();
        }

        public int CashedCheckKey { get; set; }
        public short Location { get; set; }
        public int CustomerKey { get; set; }
        public int? IssuerKey { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string CheckType { get; set; }
        public decimal CheckAmount { get; set; }
        public string CheckNo { get; set; }
        public DateTime CheckDate { get; set; }
        public double CcRate { get; set; }
        public decimal CcTotFee { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public bool Bounced { get; set; }
        public bool? CcMoneyOrder { get; set; }
        public int? DrawerzKey { get; set; }
        public bool? CcFree { get; set; }
        public decimal? CcOrigRate { get; set; }
        public byte SrcApproval { get; set; }
        public decimal CcPctFeeAmt { get; set; }
        public decimal CcFlatFeeAmt { get; set; }
        public decimal CcDiscountAmt { get; set; }
        public bool CcIsPostDated { get; set; }
        public int Dwdocid { get; set; }
        public int CurrencyKey { get; set; }
        public int? WsResponseKey { get; set; }
        public int? ImageCashLetterBundleKey { get; set; }
        public bool ElectronicCashedCheck { get; set; }
        public bool IsShredded { get; set; }

        public virtual ICollection<AttorneyLoan> AttorneyLoan { get; set; }
        public virtual ICollection<CashedCheckImage> CashedCheckImage { get; set; }
        public virtual ICollection<CashedCheckMicr> CashedCheckMicr { get; set; }
        public virtual ICollection<CashedCheckPayment> CashedCheckPayment { get; set; }
        public virtual ICollection<CourtesyPayout> CourtesyPayout { get; set; }
        public virtual ICollection<DepositBagDetail> DepositBagDetail { get; set; }
        public virtual ICollection<DepositChkDetail> DepositChkDetail { get; set; }
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemand { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual ImageCashLetterBundle ImageCashLetterBundleKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
