namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentAction")]
    public partial class AgentAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgentAction()
        {
            CollectionActions = new HashSet<CollectionAction>();
            TaskActionResults = new HashSet<TaskActionResult>();
        }

        [Key]
        public int AGENT_ACTION_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string LONG_DESCR { get; set; }

        [Required]
        [StringLength(10)]
        public string SHORT_DESCR { get; set; }

        public bool COLLECTOR_ONLY { get; set; }

        public bool LEGAL_ONLY { get; set; }

        [Required]
        [StringLength(128)]
        public string SECURITY { get; set; }

        public byte? PHONE_TYPE_CODE { get; set; }

        public byte? ADDRESS_TYPE_CODE { get; set; }

        public bool USE_ON_ADASTRA_RI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionAction> CollectionActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskActionResult> TaskActionResults { get; set; }
    }
}
