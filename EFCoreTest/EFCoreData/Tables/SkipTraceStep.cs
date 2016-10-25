using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceStep
    {
        public SkipTraceStep()
        {
            SkipTraceStepAuditCategory = new HashSet<SkipTraceStepAuditCategory>();
            SkipTraceStepLocation = new HashSet<SkipTraceStepLocation>();
            SkipTraceStepProductCode = new HashSet<SkipTraceStepProductCode>();
            SkipTraceThread = new HashSet<SkipTraceThread>();
        }

        public int SkipTraceStepKey { get; set; }
        public int SkipTraceConfigKey { get; set; }
        public int? StepActiveAlias { get; set; }
        public string StepName { get; set; }
        public short StepPriority { get; set; }
        public short DelinquencyDaysFrom { get; set; }
        public short DelinquencyDaysTo { get; set; }
        public decimal BalanceRangeFrom { get; set; }
        public decimal BalanceRangeTo { get; set; }
        public short DaysSinceLastContact { get; set; }
        public bool ProcessWhenNoHomeAddress { get; set; }
        public bool ProcessWhenNoHomePhone { get; set; }
        public bool ProcessWhenNoCellPhone { get; set; }
        public bool ProcessWhenNoWorkPhone { get; set; }
        public bool? StepActive { get; set; }
        public bool? StepCurrent { get; set; }

        public virtual ICollection<SkipTraceStepAuditCategory> SkipTraceStepAuditCategory { get; set; }
        public virtual ICollection<SkipTraceStepLocation> SkipTraceStepLocation { get; set; }
        public virtual ICollection<SkipTraceStepProductCode> SkipTraceStepProductCode { get; set; }
        public virtual ICollection<SkipTraceThread> SkipTraceThread { get; set; }
        public virtual SkipTraceConfig SkipTraceConfigKeyNavigation { get; set; }
        public virtual SkipTraceStep StepActiveAliasNavigation { get; set; }
        public virtual ICollection<SkipTraceStep> InverseStepActiveAliasNavigation { get; set; }
    }
}
