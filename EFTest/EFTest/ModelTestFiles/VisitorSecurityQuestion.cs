namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorSecurityQuestion")]
    public partial class VisitorSecurityQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitorSecurityQuestion()
        {
            Visitors = new HashSet<Visitor>();
        }

        [Key]
        public int VISITOR_SECURITY_QUESTION_KEY { get; set; }

        [Required]
        [StringLength(255)]
        public string QUESTION { get; set; }

        public byte DISPLAY_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitor> Visitors { get; set; }
    }
}
