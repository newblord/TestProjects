namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerFeedback")]
    public partial class CustomerFeedback
    {
        [Key]
        public int CUSTOMER_FEEDBACK_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int CUSTOMER_FEEDBACK_TYPE_KEY { get; set; }

        public int CUSTOMER_FEEDBACK_CATEGORY_KEY { get; set; }

        public int? CUSTOMER_FEEDBACK_RESOLUTION_KEY { get; set; }

        [Required]
        [StringLength(2000)]
        public string FEEDBACK { get; set; }

        [Required]
        [StringLength(2000)]
        public string RESOLUTION_NOTES { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime LAST_UPDATE_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerFeedbackCategory CustomerFeedbackCategory { get; set; }

        public virtual CustomerFeedbackResolution CustomerFeedbackResolution { get; set; }

        public virtual CustomerFeedbackType CustomerFeedbackType { get; set; }
    }
}
