namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusCarrier")]
    public partial class OptPlusCarrier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusCarrier()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        public int OPTPLUS_CARRIER_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string CARRIER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CARRIER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string DISPLAY_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string EMAIL_GATEWAY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_TERMINATED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
