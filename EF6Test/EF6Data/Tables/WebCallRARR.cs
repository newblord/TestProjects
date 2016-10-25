namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRARR")]
    public partial class WebCallRARR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallRARR()
        {
            WebCallQueues = new HashSet<WebCallQueue>();
            WebCallRARRFeatures = new HashSet<WebCallRARRFeature>();
        }

        [Key]
        public int WEB_CALL_RARR_KEY { get; set; }

        public int WEB_CALL_RARR_REASON_KEY { get; set; }

        public int WEB_CALL_RARR_ACTION_KEY { get; set; }

        public int WEB_CALL_RARR_RESULT1_KEY { get; set; }

        public int WEB_CALL_RARR_RESULT2_KEY { get; set; }

        public bool FOLLOW_UP_ENABLED { get; set; }

        public int FOLLOW_UP_AUTO_POPULATE { get; set; }

        public bool FOLLOW_UP_POP_UP_SETTING_DIALOG { get; set; }

        public bool DELETED { get; set; }

        public bool? Escalate_To_Supervisor { get; set; }

        public int? IATResultTypeKey { get; set; }

        public bool? DISABLED { get; set; }

        public int? Web_Call_Rarr_Group_Key { get; set; }

        public bool? UpdateCategory { get; set; }

        public int? NewCategoryId { get; set; }

        public int Points { get; set; }

        public bool SupervisorOnlyRarr { get; set; }

        public int? WEB_DIALER_RESULT_TYPE_KEY { get; set; }

        public int? WEB_CALL_RARR_TYPE_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }

        public virtual WebDialerResultType WebDialerResultType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRARRFeature> WebCallRARRFeatures { get; set; }
    }
}
