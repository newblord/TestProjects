using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardTrans
    {
        public CreditCardTrans()
        {
            LoanApplication = new HashSet<LoanApplication>();
        }

        public int CreditCardTransKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public string ReqFileType { get; set; }
        public string CcardName { get; set; }
        public decimal ChargeAmt { get; set; }
        public int? RefundTransDetailKey { get; set; }
        public int? TransDetailKey { get; set; }
        public bool? SuccessFlag { get; set; }
        public string ErrorMsg { get; set; }
        public int? TransPosKey { get; set; }
        public int? RisreptKey { get; set; }
        public string AuthCode { get; set; }
        public int? RitaTroutd { get; set; }
        public int? RitaSequenceNum { get; set; }
        public string ResultCode { get; set; }
        public string DeclineCode { get; set; }
        public string AvsCode { get; set; }
        public string CvvCode { get; set; }
        public string Token { get; set; }
        public decimal? FeeChargedAmt { get; set; }
        public int? LoanKey { get; set; }
        public string VendorResponse { get; set; }
        public string EpdqTransId { get; set; }
        public string VendorPost { get; set; }
        public short? CreditCardResultCodeKey { get; set; }
        public byte? CreditCardVendorKey { get; set; }
        public string DeclineCodeTwoChar { get; set; }
        public string AvsCodeTwoChar { get; set; }
        public string CcardNum { get; set; }
        public byte? ExpMonth { get; set; }
        public byte? ExpYear { get; set; }
        public string MagStrip { get; set; }

        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
        public virtual ZeroDollarAuth ZeroDollarAuth { get; set; }
        public virtual CreditCardVendor CreditCardVendorKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
