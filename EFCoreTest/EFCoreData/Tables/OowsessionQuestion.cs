using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OowsessionQuestion
    {
        public int OowSessionQuestionKey { get; set; }
        public int OowSessionKey { get; set; }
        public int QuestionId { get; set; }
        public int? Type { get; set; }
        public int? TimePermittedSeconds { get; set; }
        public int? ActualTimeSeconds { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Oowsession OowSessionKeyNavigation { get; set; }
    }
}
