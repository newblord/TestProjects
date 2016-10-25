namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CpiuMaster")]
    public partial class CpiuMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CpiuMaster()
        {
            CpiuDetails = new HashSet<CpiuDetail>();
        }

        [Key]
        public int CPIU_MASTER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IMPORTED_DATETIME { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(250)]
        public string FILE_NAME { get; set; }

        public int COLLECTION_AGENCY_KEY { get; set; }

        public bool FINISHED { get; set; }

        [StringLength(3)]
        public string FINISHED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FINISHED_DATETIME { get; set; }

        public bool LOCKED { get; set; }

        [StringLength(3)]
        public string LOCKED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LOCKED_DATETIME { get; set; }

        public virtual CollectionAgency CollectionAgency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuDetail> CpiuDetails { get; set; }
    }
}
