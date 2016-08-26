namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallVisitorAlertsAudit")]
    public partial class WebCallVisitorAlertsAudit
    {
        [Key]
        public int Web_Call_VisitorAlertAuditId { get; set; }

        public DateTime AuditDate { get; set; }

        [Required]
        [StringLength(50)]
        public string AuditType { get; set; }

        public int Web_Call_VisitorAlertId { get; set; }

        public int VisitorId { get; set; }

        [Required]
        [StringLength(2000)]
        public string AlertNote { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(100)]
        public string LastEditedBy { get; set; }

        public DateTime LastEditDate { get; set; }
    }
}
