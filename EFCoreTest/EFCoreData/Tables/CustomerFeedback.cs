using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFeedback
    {
        public int CustomerFeedbackKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public int CustomerFeedbackTypeKey { get; set; }
        public int CustomerFeedbackCategoryKey { get; set; }
        public int? CustomerFeedbackResolutionKey { get; set; }
        public string Feedback { get; set; }
        public string ResolutionNotes { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual CustomerFeedbackCategory CustomerFeedbackCategoryKeyNavigation { get; set; }
        public virtual CustomerFeedbackResolution CustomerFeedbackResolutionKeyNavigation { get; set; }
        public virtual CustomerFeedbackType CustomerFeedbackTypeKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
