namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanWebReviewTemplateXref")]
    public partial class LoanWebReviewTemplateXref
    {
        [Key]
        public int LOAN_WEB_REVIEW_TEMPLATE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int WEB_REVIEW_TEMPLATE_KEY { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual WebReviewTemplate WebReviewTemplate { get; set; }
    }
}
