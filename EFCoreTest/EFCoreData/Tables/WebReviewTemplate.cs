using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebReviewTemplate
    {
        public WebReviewTemplate()
        {
            LoanWebReviewTemplateXref = new HashSet<LoanWebReviewTemplateXref>();
        }

        public int WebReviewTemplateKey { get; set; }
        public short Location { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string Template { get; set; }

        public virtual ICollection<LoanWebReviewTemplateXref> LoanWebReviewTemplateXref { get; set; }
    }
}
