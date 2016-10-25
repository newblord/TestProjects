namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailTemplate")]
    public partial class EmailTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailTemplate()
        {
            VisitorEmails = new HashSet<VisitorEmail>();
        }

        [Key]
        public int EMAIL_TEMPLATE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public bool IS_ACTIVE { get; set; }

        public byte EMAIL_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_FROM { get; set; }

        [Required]
        [StringLength(500)]
        public string SUBJECT_LINE { get; set; }

        [Required]
        [StringLength(8000)]
        public string BODY_HTML { get; set; }

        [Required]
        [StringLength(500)]
        public string NOTES { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEmail> VisitorEmails { get; set; }
    }
}
