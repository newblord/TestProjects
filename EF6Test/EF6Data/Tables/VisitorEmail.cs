namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorEmail")]
    public partial class VisitorEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitorEmail()
        {
            VisitorEmailDispositions = new HashSet<VisitorEmailDisposition>();
            WebBlobVisitorEmailXrefs = new HashSet<WebBlobVisitorEmailXref>();
        }

        [Key]
        public int VISITOR_EMAIL_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        [Required]
        [StringLength(60)]
        public string EMAIL_ADDRESS { get; set; }

        public byte EMAIL_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_SUBJECT { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EMAIL_BODY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [StringLength(1)]
        public string EMAIL_ORIGINATION { get; set; }

        [StringLength(60)]
        public string EMAIL_FROM_ADDRESS { get; set; }

        public int? EMAIL_TEMPLATE_KEY { get; set; }

        public DateTime? EMAIL_DATE { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorEmailDisposition> VisitorEmailDispositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobVisitorEmailXref> WebBlobVisitorEmailXrefs { get; set; }
    }
}
