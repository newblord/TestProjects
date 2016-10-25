namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallQueueType")]
    public partial class WebCallQueueType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallQueueType()
        {
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
        }

        [Key]
        public int WEB_CALL_QUEUE_TYPE_KEY { get; set; }

        [StringLength(25)]
        public string DESCRIPTION { get; set; }

        public bool? KEEP_OPEN { get; set; }

        public int? POP_PRIORITY { get; set; }

        public DateTime? DATE_ENTERED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }
    }
}
