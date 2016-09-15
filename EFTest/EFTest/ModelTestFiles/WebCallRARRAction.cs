namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRARRAction")]
    public partial class WebCallRARRAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallRARRAction()
        {
            WebCallQueues = new HashSet<WebCallQueue>();
        }

        [Key]
        public int WEB_CALL_RARR_ACTION_KEY { get; set; }

        [Required]
        [StringLength(5)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool DELETED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }
    }
}
