using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFeedbackTypeCategoryXref
    {
        public int CustomerFeedbackTypeCategoryXrefKey { get; set; }
        public int CustomerFeedbackTypeKey { get; set; }
        public int CustomerFeedbackCategoryKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual CustomerFeedbackCategory CustomerFeedbackCategoryKeyNavigation { get; set; }
        public virtual CustomerFeedbackType CustomerFeedbackTypeKeyNavigation { get; set; }
    }
}
