using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GlobalStates
    {
        public GlobalStates()
        {
            Company = new HashSet<Company>();
            IncomeVerificationMessage = new HashSet<IncomeVerificationMessage>();
            PrescreenQuestionState = new HashSet<PrescreenQuestionState>();
        }

        public int GlobalStatesKey { get; set; }
        public string StateAbbrv { get; set; }
        public decimal TlLienFee { get; set; }
        public short TlAprDays { get; set; }
        public decimal TlTitleFee { get; set; }
        public decimal TlQuickTitleFee { get; set; }
        public decimal TlTitleProcFee { get; set; }
        public decimal TlNoticeOfLienFee { get; set; }
        public bool EnableCustMilitaryStatus { get; set; }
        public string StateFull { get; set; }
        public bool RequireCustIdScan { get; set; }
        public bool EnableNotifyRepoCompanyMsg { get; set; }
        public short MinLoanAge { get; set; }
        public bool EnableSingleOpenLoanType { get; set; }
        public bool EnableLoanMaintOtherStates { get; set; }
        public decimal TlNoLienFeeForLoansUpTo { get; set; }
        public short DueDatePaymentsThreadCount { get; set; }
        public bool ShowAccessKey { get; set; }
        public bool EnableMarketingInvitations { get; set; }
        public string MarketingInvitationOverridesType { get; set; }
        public int MarketingInvitationIncomePct { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<IncomeVerificationMessage> IncomeVerificationMessage { get; set; }
        public virtual ICollection<PrescreenQuestionState> PrescreenQuestionState { get; set; }
    }
}
