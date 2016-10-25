namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallApplicationModeAudit")]
    public partial class WebCallApplicationModeAudit
    {
        [Key]
        public int Web_Call_Application_Mode_Audit_Key { get; set; }

        public int Web_Call_Application_Mode_Key { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public virtual WebCallApplicationMode WebCallApplicationMode { get; set; }
    }
}
