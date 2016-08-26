namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerResult")]
    public partial class WebDialerResult
    {
        [Key]
        public int WEB_DIALER_RESULT_KEY { get; set; }

        [Required]
        [StringLength(128)]
        public string RESULT { get; set; }

        [Required]
        [StringLength(50)]
        public string LIST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PHONE_TYPE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? WEB_CALL_QUEUE_KEY { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(50)]
        public string INCOMING_DID { get; set; }

        public DateTime? AUDIO_DROPPED_DATE { get; set; }

        public DateTime? CALL_ENDED_DATE { get; set; }

        public int? WEB_DIALER_RESULT_TYPE_KEY { get; set; }

        [StringLength(20)]
        public string ANI { get; set; }

        public int? ANI_COUNTRY_CODE { get; set; }

        public TimeSpan? BILL_TIME { get; set; }

        [StringLength(25)]
        public string CALL_TYPE { get; set; }

        public int? CALLS { get; set; }

        [StringLength(100)]
        public string CAMPAIGN { get; set; }

        [StringLength(100)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string COMMENTS { get; set; }

        public bool? CONTACT { get; set; }

        public decimal? COST { get; set; }

        public DateTime? CALL_DATE { get; set; }

        [StringLength(20)]
        public string DESTINATION_AGENT { get; set; }

        [StringLength(50)]
        public string DISPOSITION { get; set; }

        [StringLength(20)]
        public string DNIS { get; set; }

        public int? DNIS_COUNTRY_CODE { get; set; }

        public bool? DROPPED { get; set; }

        public TimeSpan? DURATION { get; set; }

        public TimeSpan? HANDLE_TIME { get; set; }

        public TimeSpan? HOLD_TIME { get; set; }

        [StringLength(100)]
        public string IVR_FLOW { get; set; }

        public TimeSpan? MANUAL_DIALING_TIME { get; set; }

        public TimeSpan? PREVIEW_TIME { get; set; }

        public int? PRIORITY { get; set; }

        public TimeSpan? QUEUE_TIME { get; set; }

        public decimal? RATE { get; set; }

        public int? SERVICE_LEVEL { get; set; }

        [StringLength(100)]
        public string SESSION_ID { get; set; }

        [StringLength(100)]
        public string SKILL { get; set; }

        public TimeSpan? SPEED_OF_ANSWER { get; set; }

        public TimeSpan? TALK_TIME { get; set; }

        public DateTime? WORK_ITEM_DATE { get; set; }

        public TimeSpan? THIRD_PARTY_TALK_TIME { get; set; }

        public TimeSpan? WRAP_TIME { get; set; }

        public bool? IS_COMPLETE { get; set; }

        [StringLength(50)]
        public string AGENT { get; set; }

        [StringLength(50)]
        public string AGENT_EMAIL { get; set; }

        public int? AGENT_EXTENSION { get; set; }

        [StringLength(50)]
        public string AGENT_NAME { get; set; }

        public int? ANI_AREA_CODE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(100)]
        public string COMPANY { get; set; }

        [StringLength(100)]
        public string COUNTRY { get; set; }

        [StringLength(50)]
        public string DEST_AGENT_EMAIL { get; set; }

        public int? DEST_AGENT_EXTENSION { get; set; }

        [StringLength(50)]
        public string DEST_AGENT_NAME { get; set; }

        public int? DNIS_AREA_CODE { get; set; }

        [StringLength(24)]
        public string FIRST_NAME { get; set; }

        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [StringLength(25)]
        public string NUMBER1 { get; set; }

        [StringLength(25)]
        public string NUMBER2 { get; set; }

        [StringLength(25)]
        public string NUMBER3 { get; set; }

        [StringLength(20)]
        public string CALLED_STATE { get; set; }

        [StringLength(50)]
        public string STREET { get; set; }

        public TimeSpan? CALL_TIME { get; set; }

        public DateTime? TIME_STAMP { get; set; }

        [StringLength(10)]
        public string ZIP { get; set; }

        [StringLength(10)]
        public string MARKETING_SENT_KEY { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }

        public virtual WebDialerResultType WebDialerResultType { get; set; }
    }
}
