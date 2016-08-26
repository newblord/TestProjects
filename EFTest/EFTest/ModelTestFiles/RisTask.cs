namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RisTask")]
    public partial class RisTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RisTask()
        {
            RIS = new HashSet<RI>();
        }

        [Required]
        [StringLength(1)]
        public string TASK { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC { get; set; }

        [Required]
        [StringLength(10)]
        public string SHORT { get; set; }

        [Key]
        public int RIS_TASK_ID { get; set; }

        public bool DISPLAYED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RI> RIS { get; set; }
    }
}
