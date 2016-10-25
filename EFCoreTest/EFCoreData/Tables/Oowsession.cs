using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Oowsession
    {
        public Oowsession()
        {
            OowsessionAlert = new HashSet<OowsessionAlert>();
            OowsessionError = new HashSet<OowsessionError>();
            OowsessionQuestion = new HashSet<OowsessionQuestion>();
        }

        public int OowSessionKey { get; set; }
        public int VisitorKey { get; set; }
        public int SessionId { get; set; }
        public string ExternalId { get; set; }
        public int? EarnedPoints { get; set; }
        public int? PossiblePoints { get; set; }
        public int? TransunionConfidenceScore { get; set; }
        public string TransunionDecision { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<OowsessionAlert> OowsessionAlert { get; set; }
        public virtual ICollection<OowsessionError> OowsessionError { get; set; }
        public virtual ICollection<OowsessionQuestion> OowsessionQuestion { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
