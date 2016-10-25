using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CpiuDetail
    {
        public CpiuDetail()
        {
            CpiuExceptionReport = new HashSet<CpiuExceptionReport>();
        }

        public int CpiuDetailKey { get; set; }
        public int CpiuMasterKey { get; set; }
        public string AgencyReference { get; set; }
        public string Reference { get; set; }
        public int? RisreptKey { get; set; }
        public int? CustomerKey { get; set; }
        public short? Location { get; set; }
        public string Note { get; set; }
        public decimal PaymentAmt { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CheckNo { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDatetime { get; set; }
        public string PostedTeller { get; set; }
        public int? TransDetailKey { get; set; }
        public string ErrorMsg { get; set; }
        public bool IsPif { get; set; }
        public bool IsSif { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientPostcode { get; set; }
        public DateTime? ClientDob { get; set; }
        public bool DoNotPost { get; set; }
        public DateTime? DoNotPostDatetime { get; set; }
        public string DoNotPostTeller { get; set; }

        public virtual ICollection<CpiuExceptionReport> CpiuExceptionReport { get; set; }
        public virtual CpiuMaster CpiuMasterKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
