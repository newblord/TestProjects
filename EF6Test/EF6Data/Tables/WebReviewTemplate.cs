namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebReviewTemplate")]
    public partial class WebReviewTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebReviewTemplate()
        {
            LoanWebReviewTemplateXrefs = new HashSet<LoanWebReviewTemplateXref>();
        }

        [Key]
        public int WEB_REVIEW_TEMPLATE_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        public string TEMPLATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanWebReviewTemplateXref> LoanWebReviewTemplateXrefs { get; set; }
    }
}
