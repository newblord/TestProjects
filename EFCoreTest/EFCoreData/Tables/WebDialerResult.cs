using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerResult
    {
        public int WebDialerResultKey { get; set; }
        public string Result { get; set; }
        public string ListName { get; set; }
        public string PhoneType { get; set; }
        public DateTime DateEntered { get; set; }
        public int? VisitorKey { get; set; }
        public int? WebCallQueueKey { get; set; }
        public string Teller { get; set; }
        public string IncomingDid { get; set; }
        public DateTime? AudioDroppedDate { get; set; }
        public DateTime? CallEndedDate { get; set; }
        public int? WebDialerResultTypeKey { get; set; }
        public string Ani { get; set; }
        public int? AniCountryCode { get; set; }
        public TimeSpan? BillTime { get; set; }
        public string CallType { get; set; }
        public int? Calls { get; set; }
        public string Campaign { get; set; }
        public string Category { get; set; }
        public string Comments { get; set; }
        public bool? Contact { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? CallDate { get; set; }
        public string DestinationAgent { get; set; }
        public string Disposition { get; set; }
        public string Dnis { get; set; }
        public int? DnisCountryCode { get; set; }
        public bool? Dropped { get; set; }
        public TimeSpan? Duration { get; set; }
        public TimeSpan? HandleTime { get; set; }
        public TimeSpan? HoldTime { get; set; }
        public string IvrFlow { get; set; }
        public TimeSpan? ManualDialingTime { get; set; }
        public TimeSpan? PreviewTime { get; set; }
        public int? Priority { get; set; }
        public TimeSpan? QueueTime { get; set; }
        public decimal? Rate { get; set; }
        public int? ServiceLevel { get; set; }
        public string SessionId { get; set; }
        public string Skill { get; set; }
        public TimeSpan? SpeedOfAnswer { get; set; }
        public TimeSpan? TalkTime { get; set; }
        public DateTime? WorkItemDate { get; set; }
        public TimeSpan? ThirdPartyTalkTime { get; set; }
        public TimeSpan? WrapTime { get; set; }
        public bool? IsComplete { get; set; }
        public string Agent { get; set; }
        public string AgentEmail { get; set; }
        public int? AgentExtension { get; set; }
        public string AgentName { get; set; }
        public int? AniAreaCode { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string DestAgentEmail { get; set; }
        public int? DestAgentExtension { get; set; }
        public string DestAgentName { get; set; }
        public int? DnisAreaCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Number3 { get; set; }
        public string CalledState { get; set; }
        public string Street { get; set; }
        public TimeSpan? CallTime { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Zip { get; set; }
        public string MarketingSentKey { get; set; }

        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
        public virtual WebDialerResultType WebDialerResultTypeKeyNavigation { get; set; }
    }
}
