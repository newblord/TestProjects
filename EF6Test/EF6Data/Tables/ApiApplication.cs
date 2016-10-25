namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiApplication")]
    public partial class ApiApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiApplication()
        {
            VisitorApiAuthorizations = new HashSet<VisitorApiAuthorization>();
        }

        [Key]
        public int API_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public Guid TOKEN { get; set; }

        [Required]
        [StringLength(100)]
        public string SECRET { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorizations { get; set; }
    }
}
