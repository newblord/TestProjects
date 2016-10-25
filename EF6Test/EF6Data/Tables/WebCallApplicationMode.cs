namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallApplicationMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallApplicationMode()
        {
            WebCallApplicationModeAudits = new HashSet<WebCallApplicationModeAudit>();
        }

        [Key]
        public int Web_Call_Application_Mode_Key { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Activation_Event { get; set; }

        public int OnSelected_Action { get; set; }

        public bool Disabled { get; set; }

        public int Display_Order { get; set; }

        public DateTime Date_Entered { get; set; }

        public bool Deleted { get; set; }

        public bool IsWorkingHoursMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallApplicationModeAudit> WebCallApplicationModeAudits { get; set; }
    }
}
