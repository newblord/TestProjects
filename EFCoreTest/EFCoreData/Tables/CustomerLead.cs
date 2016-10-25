using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerLead
    {
        public CustomerLead()
        {
            CustomerLeadActivity = new HashSet<CustomerLeadActivity>();
            CustomerLeadNote = new HashSet<CustomerLeadNote>();
        }

        public int CustomerLeadKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public string LeadSource { get; set; }
        public short OrigLocation { get; set; }
        public short Superstore { get; set; }
        public short? Satellite { get; set; }
        public int CustomerLeadStatusKey { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public int? CustomerLeadReasonKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanKey { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public DateTime? Dob { get; set; }
        public string HomeAddrNum { get; set; }
        public string HomeAddrPreDir { get; set; }
        public string HomeAddrStreet { get; set; }
        public string HomeAddrSuffix { get; set; }
        public string HomeAddrPostDir { get; set; }
        public string HomeAddrSuite { get; set; }
        public string HomeAddrSuiteNum { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomeZipcode { get; set; }
        public DateTime? ResidenceSince { get; set; }
        public byte? Ownrentother { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public int? MobileCarrier { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExt { get; set; }
        public string PreferredContact { get; set; }
        public string Email { get; set; }
        public string PayCycle { get; set; }
        public decimal? GrossIncome { get; set; }
        public decimal? NetIncome { get; set; }
        public decimal? PvbdIncome { get; set; }
        public string AbaNum { get; set; }
        public string AcctNo { get; set; }
        public DateTime? ApptFollowDate { get; set; }
        public string ApptFollowTime { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string TellerUpdated { get; set; }
        public int? VisitorKey { get; set; }
        public string HomeAddressLine { get; set; }

        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivity { get; set; }
        public virtual ICollection<CustomerLeadNote> CustomerLeadNote { get; set; }
        public virtual CustomerLeadReason CustomerLeadReasonKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
