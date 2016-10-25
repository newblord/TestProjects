using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerCallResult
    {
        public int WebDialerCallResultKey { get; set; }
        public bool? Abandoned { get; set; }
        public TimeSpan? AfterCallWorkTime { get; set; }
        public string Agent { get; set; }
        public string Ani { get; set; }
        public int? AniAreaCode { get; set; }
        public int? AniCountryCode { get; set; }
        public string AniState { get; set; }
        public TimeSpan? BillTime { get; set; }
        public int? Calls { get; set; }
        public int? CallsCompletedInIvr { get; set; }
        public int? CallsTimedOutInIvr { get; set; }
        public int? CallId { get; set; }
        public TimeSpan? CallTime { get; set; }
        public string CallType { get; set; }
        public string Campaign { get; set; }
        public int? Conferences { get; set; }
        public TimeSpan? ConferenceTime { get; set; }
        public TimeSpan? ConsultTime { get; set; }
        public bool? Contacted { get; set; }
        public int? ContactId { get; set; }
        public decimal? Cost { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string DestinationAgent { get; set; }
        public string Disposition { get; set; }
        public string Dnis { get; set; }
        public int? DnisAreaCode { get; set; }
        public int? DnisCountryCode { get; set; }
        public string DnisState { get; set; }
        public int? Extension { get; set; }
        public TimeSpan? HandleTime { get; set; }
        public int? Holds { get; set; }
        public TimeSpan? HoldTime { get; set; }
        public bool? IsComplete { get; set; }
        public string IvrPath { get; set; }
        public TimeSpan? IvrTime { get; set; }
        public DateTime? LastModified { get; set; }
        public string ListName { get; set; }
        public TimeSpan? ManualDialingTime { get; set; }
        public int? MarketingSentKey { get; set; }
        public string Notes { get; set; }
        public int? Parks { get; set; }
        public TimeSpan? ParkTime { get; set; }
        public TimeSpan? PreviewTime { get; set; }
        public int? Priority { get; set; }
        public TimeSpan? QueueWaitTime { get; set; }
        public decimal? Rate { get; set; }
        public string Result { get; set; }
        public TimeSpan? RingTime { get; set; }
        public int? RisreptKey { get; set; }
        public int? ServiceLevel { get; set; }
        public string SessionId { get; set; }
        public string Skill { get; set; }
        public TimeSpan? SpeedOfAnswer { get; set; }
        public TimeSpan? TalkTime { get; set; }
        public TimeSpan? TalkTimeLessHoldAndPark { get; set; }
        public string Teller { get; set; }
        public TimeSpan? ThirdPartyTalkTime { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? Transfers { get; set; }
        public int? VisitorKey { get; set; }
        public int? WebCallQueueKey { get; set; }
        public int? WebDialerResultTypeKey { get; set; }
        public int? ApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public int? Location { get; set; }
        public string MrktCampaign { get; set; }
        public int? QueueType { get; set; }
        public string NobleHash { get; set; }
    }
}
