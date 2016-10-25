namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectionNote")]
    public partial class CollectionNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionNote()
        {
            RepoCaseHistories = new HashSet<RepoCaseHistory>();
        }

        [Key]
        public int COLLECTION_NOTE_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RTF_NOTE { get; set; }

        public bool IS_FLASH { get; set; }

        public bool IS_DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        public int? NEW_COLLECTION_NOTE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepoCaseHistory> RepoCaseHistories { get; set; }
    }
}
