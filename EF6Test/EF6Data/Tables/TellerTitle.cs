namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerTitle")]
    public partial class TellerTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TellerTitle()
        {
            TELLERIDs = new HashSet<TELLERID>();
            TellerTitleEdits = new HashSet<TellerTitleEdit>();
        }

        [Key]
        public int TITLE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string TITLE { get; set; }

        public bool ACTIVE { get; set; }

        public bool DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELLERID> TELLERIDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TellerTitleEdit> TellerTitleEdits { get; set; }
    }
}
