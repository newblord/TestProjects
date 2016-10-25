namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRARRHistory")]
    public partial class WebCallRARRHistory
    {
        [Key]
        public int WEB_CALL_RARR_HISTORY_KEY { get; set; }

        public int WEB_CALL_RARR_KEY { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string CREATED_BY { get; set; }

        public DateTime CREATE_DATE { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTES { get; set; }

        public bool IS_FOLLOWUP { get; set; }

        public DateTime? FOLLOWUP_DATE { get; set; }

        [Required]
        [StringLength(1000)]
        public string Source { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForceApprovedAmount { get; set; }

        public int? Rarr_Group_Key { get; set; }

        [StringLength(150)]
        public string Rarr_Group_Name { get; set; }

        public int? Rarr_Group_Points { get; set; }

        public int? Team_Key { get; set; }

        [StringLength(50)]
        public string Team_Name { get; set; }

        public int? WEB_DIALER_RESULT_KEY { get; set; }

        public bool? SuppressRarrPoints { get; set; }

        [StringLength(200)]
        public string SuppressPointsReason { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }
    }
}
