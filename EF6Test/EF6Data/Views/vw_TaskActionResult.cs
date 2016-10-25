namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_TaskActionResult
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string AGENT_ACTION_DESC { get; set; }

        [StringLength(100)]
        public string AGENT_RESULT1_DESC { get; set; }

        [StringLength(100)]
        public string AGENT_RESULT2_DESC { get; set; }

        [StringLength(50)]
        public string RIS_Audit_DESC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TASK_ACTION_RESULT_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AGENT_ACTION_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AGENT_RESULT_KEY1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AGENT_RESULT_KEY2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RIS_AUDIT_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ALLOW_NOTE { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FOLLOWUP_MAX { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool SHOW_PAYMENT_FORM { get; set; }

        public bool? SHOW_PTP_FORM { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool COLLECTOR_BONUS_RPT { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool OPT_AUDIT_CAT_CODE { get; set; }

        public byte? CBR_OUT_OR_IN_CALL { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FOLLOWUP_DEFAULT { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool REQUIRE_REASON_FOR_ARREARS { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool SHOW_FLOD_FORM { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte HOT_KEY { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool SHOW_REPO_VENDOR_LIST { get; set; }
    }
}
