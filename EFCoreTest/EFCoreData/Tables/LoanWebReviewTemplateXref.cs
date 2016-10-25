using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanWebReviewTemplateXref
    {
        public int LoanWebReviewTemplateKey { get; set; }
        public int LoanKey { get; set; }
        public int WebReviewTemplateKey { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual WebReviewTemplate WebReviewTemplateKeyNavigation { get; set; }
    }
}
