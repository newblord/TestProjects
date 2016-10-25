namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InternalProcessEmail")]
    public partial class InternalProcessEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InternalProcessEmail()
        {
            InternalProcessEmailBodies = new HashSet<InternalProcessEmailBody>();
        }

        [Key]
        public int INTERNAL_PROCESS_EMAIL_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string RECIPIENTS { get; set; }

        [Required]
        [StringLength(100)]
        public string SUBJECT { get; set; }

        public byte INTERNAL_PROCESS_EMAIL_TYPE_KEY { get; set; }

        public bool PROCESSED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternalProcessEmailBody> InternalProcessEmailBodies { get; set; }
    }
}
