using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallWorkQueue
    {
        public int WebCallWorkQueueKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public string WebCallQueueSessionKey { get; set; }
        public DateTime? OnlineCreatedDateTime { get; set; }
        public DateTime? OfflineCreatedDateTime { get; set; }
        public int WebCallQueueCategoryKey { get; set; }
        public int WebCallQueueEditedCampaignKey { get; set; }
        public int WebCallQueueAssignedCampaignKey { get; set; }
        public string Page { get; set; }
        public int WebCallQueueStatusKey { get; set; }
        public bool SupervisorEscallation { get; set; }
        public string Csr { get; set; }
        public string Teller { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public int? WebCallReasonKey { get; set; }
        public int? WebCallActionKey { get; set; }
        public int? WebCallResult1Key { get; set; }
        public int? WebCallResult2Key { get; set; }
        public int? WebCallRarrKey { get; set; }
        public string Notes { get; set; }
        public DateTime? FollowUpdate { get; set; }
        public bool Completed { get; set; }
        public bool Checkedout { get; set; }
        public Guid WebCallChatSessionKey { get; set; }
        public string WebCallChatCsrKey { get; set; }
        public int? WebCallLoanAppKey { get; set; }
        public int? WebCallCustomerKey { get; set; }
        public int? WebCallVisitorKey { get; set; }
        public string WebStatus { get; set; }
        public int? DialerStatus { get; set; }
        public int? LoanKey { get; set; }
        public int? DialerCampaign { get; set; }
        public DateTime? DialerDate { get; set; }
        public string WebSource { get; set; }
        public short? Location { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string LeadId { get; set; }
        public string Zipcode { get; set; }
        public string Buyer { get; set; }
        public decimal? SoldAmount { get; set; }
        public string FinalScore { get; set; }
        public int? WorkItemColor { get; set; }
        public int? WebCallQueueTypeKey { get; set; }
        public bool? DdContactHr { get; set; }
        public int? DdContactAttempts { get; set; }
        public DateTime? DdLastContactAttemptDate { get; set; }
        public int? OptplusCardDetailKey { get; set; }
        public int? PhoneCount { get; set; }
        public bool? ItsupportEscallation { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsOnline { get; set; }
        public string MarketingSentKey { get; set; }
        public int? RisreptKey { get; set; }
        public long? WebVisitKey { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual OptPlusCardDetail OptplusCardDetailKeyNavigation { get; set; }
        public virtual Customer WebCallCustomerKeyNavigation { get; set; }
        public virtual LoanApplication WebCallLoanAppKeyNavigation { get; set; }
        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
        public virtual WebCallQueueType WebCallQueueTypeKeyNavigation { get; set; }
        public virtual Visitor WebCallVisitorKeyNavigation { get; set; }
    }
}
