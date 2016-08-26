namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallBatchTask")]
    public partial class WebCallBatchTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallBatchTask()
        {
            WebCallBatchActions = new HashSet<WebCallBatchAction>();
            WebCallBatchCriterias = new HashSet<WebCallBatchCriteria>();
        }

        [Key]
        public int Web_Call_BatchTask_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        public bool Enabled { get; set; }

        public DateTime Create_Date { get; set; }

        [Required]
        [StringLength(3)]
        public string Created_By { get; set; }

        public bool AllowScheduling { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallBatchAction> WebCallBatchActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallBatchCriteria> WebCallBatchCriterias { get; set; }
    }
}
