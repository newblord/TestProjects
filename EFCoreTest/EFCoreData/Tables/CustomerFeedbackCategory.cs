using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFeedbackCategory
    {
        public CustomerFeedbackCategory()
        {
            CustomerFeedback = new HashSet<CustomerFeedback>();
            CustomerFeedbackTypeCategoryXref = new HashSet<CustomerFeedbackTypeCategoryXref>();
        }

        public int CustomerFeedbackCategoryKey { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<CustomerFeedback> CustomerFeedback { get; set; }
        public virtual ICollection<CustomerFeedbackTypeCategoryXref> CustomerFeedbackTypeCategoryXref { get; set; }
    }
}
