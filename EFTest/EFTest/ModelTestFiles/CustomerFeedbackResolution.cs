namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerFeedbackResolution")]
    public partial class CustomerFeedbackResolution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerFeedbackResolution()
        {
            CustomerFeedbacks = new HashSet<CustomerFeedback>();
        }

        [Key]
        public int CUSTOMER_FEEDBACK_RESOLUTION_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_CLOSED { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime LAST_UPDATE_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }
    }
}
