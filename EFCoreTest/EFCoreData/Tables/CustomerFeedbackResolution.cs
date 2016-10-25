using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFeedbackResolution
    {
        public CustomerFeedbackResolution()
        {
            CustomerFeedback = new HashSet<CustomerFeedback>();
        }

        public int CustomerFeedbackResolutionKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsClosed { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<CustomerFeedback> CustomerFeedback { get; set; }
    }
}
