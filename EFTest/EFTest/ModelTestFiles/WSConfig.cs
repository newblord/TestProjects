namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSConfig")]
    public partial class WSConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSConfig()
        {
            WSOperations = new HashSet<WSOperation>();
            WSResponses = new HashSet<WSResponse>();
        }

        [Key]
        public int WS_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string PROVIDER_NAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string PROVIDER_DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(10)]
        public string PROVIDER_VERSION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSOperation> WSOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSResponse> WSResponses { get; set; }
    }
}
