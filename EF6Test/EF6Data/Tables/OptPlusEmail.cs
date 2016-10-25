namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusEmail")]
    public partial class OptPlusEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusEmail()
        {
            OptPlusEmailLocations = new HashSet<OptPlusEmailLocation>();
        }

        [Key]
        public int OPTPLUS_EMAIL_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ADDRESS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusEmailLocation> OptPlusEmailLocations { get; set; }
    }
}
