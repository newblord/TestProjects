using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DialerJob
    {
        public int DialerJobKey { get; set; }
        public string JobName { get; set; }
        public short StepOrder { get; set; }
        public string Description { get; set; }
        public string ExportFileName { get; set; }
        public string JobType { get; set; }
        public bool IsAdAstra { get; set; }
        public string Locations { get; set; }
        public string Products { get; set; }
        public string AuditCategories { get; set; }
        public decimal BalanceFrom { get; set; }
        public decimal BalanceTo { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public short ScoreFrom { get; set; }
        public short ScoreTo { get; set; }
        public string LastNameFrom { get; set; }
        public string LastNameTo { get; set; }
        public string FollowUpFrom { get; set; }
        public string FollowUpTo { get; set; }
        public bool PtpCall { get; set; }
        public bool ValidCc { get; set; }
        public bool DirectDeposit { get; set; }
        public bool TodayPrior { get; set; }
        public bool TodayPlus1 { get; set; }
        public bool TodayPlus2 { get; set; }
        public bool RunSunday { get; set; }
        public bool RunMonday { get; set; }
        public bool RunTuesday { get; set; }
        public bool RunWednesday { get; set; }
        public bool RunThursday { get; set; }
        public bool RunFriday { get; set; }
        public bool RunSaturday { get; set; }
        public string RiskAssessment { get; set; }
        public int AdastraAgeFrom { get; set; }
        public int AdastraAgeTo { get; set; }
        public string ExcludePhoneAreacodes { get; set; }
        public bool HasBrokenPtps { get; set; }
        public int BrokenPtpDays { get; set; }
        public decimal BalanceTest { get; set; }
        public string PreferredLanguage { get; set; }
    }
}
