namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskActionResult")]
    public partial class TaskActionResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskActionResult()
        {
            TaskActionResultXrefs = new HashSet<TaskActionResultXref>();
        }

        [Key]
        public int TASK_ACTION_RESULT_KEY { get; set; }

        public int AGENT_ACTION_KEY { get; set; }

        public int AGENT_RESULT_KEY1 { get; set; }

        public int AGENT_RESULT_KEY2 { get; set; }

        public int RIS_AUDIT_ID { get; set; }

        public bool ALLOW_NOTE { get; set; }

        public int FOLLOWUP_MAX { get; set; }

        public bool SHOW_PAYMENT_FORM { get; set; }

        public bool? SHOW_PTP_FORM { get; set; }

        public bool COLLECTOR_BONUS_RPT { get; set; }

        public bool OPT_AUDIT_CAT_CODE { get; set; }

        public byte? CBR_OUT_OR_IN_CALL { get; set; }

        public int FOLLOWUP_DEFAULT { get; set; }

        public bool REQUIRE_REASON_FOR_ARREARS { get; set; }

        public bool SHOW_FLOD_FORM { get; set; }

        public byte HOT_KEY { get; set; }

        public bool SHOW_REPO_VENDOR_LIST { get; set; }

        public virtual AgentAction AgentAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskActionResultXref> TaskActionResultXrefs { get; set; }
    }
}
