namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerFeedbackTypeCategoryXRef")]
    public partial class CustomerFeedbackTypeCategoryXRef
    {
        [Key]
        public int CUSTOMER_FEEDBACK_TYPE_CATEGORY_XREF_KEY { get; set; }

        public int CUSTOMER_FEEDBACK_TYPE_KEY { get; set; }

        public int CUSTOMER_FEEDBACK_CATEGORY_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual CustomerFeedbackCategory CustomerFeedbackCategory { get; set; }

        public virtual CustomerFeedbackType CustomerFeedbackType { get; set; }
    }
}
