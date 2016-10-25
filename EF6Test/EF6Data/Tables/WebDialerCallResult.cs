namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerCallResult")]
    public partial class WebDialerCallResult
    {
        [Key]
        public int WEB_DIALER_CALL_RESULT_KEY { get; set; }

        public bool? ABANDONED { get; set; }

        public TimeSpan? AFTER_CALL_WORK_TIME { get; set; }

        [StringLength(50)]
        public string AGENT { get; set; }

        [StringLength(20)]
        public string ANI { get; set; }

        public int? ANI_AREA_CODE { get; set; }

        public int? ANI_COUNTRY_CODE { get; set; }

        [StringLength(32)]
        public string ANI_STATE { get; set; }

        public TimeSpan? BILL_TIME { get; set; }

        public int? CALLS { get; set; }

        public int? CALLS_COMPLETED_IN_IVR { get; set; }

        public int? CALLS_TIMED_OUT_IN_IVR { get; set; }

        public int? CALL_ID { get; set; }

        public TimeSpan? CALL_TIME { get; set; }

        [StringLength(25)]
        public string CALL_TYPE { get; set; }

        [StringLength(100)]
        public string CAMPAIGN { get; set; }

        public int? CONFERENCES { get; set; }

        public TimeSpan? CONFERENCE_TIME { get; set; }

        public TimeSpan? CONSULT_TIME { get; set; }

        public bool? CONTACTED { get; set; }

        public int? CONTACT_ID { get; set; }

        public decimal? COST { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [StringLength(20)]
        public string DESTINATION_AGENT { get; set; }

        [StringLength(50)]
        public string DISPOSITION { get; set; }

        [StringLength(20)]
        public string DNIS { get; set; }

        public int? DNIS_AREA_CODE { get; set; }

        public int? DNIS_COUNTRY_CODE { get; set; }

        [StringLength(32)]
        public string DNIS_STATE { get; set; }

        public int? EXTENSION { get; set; }

        public TimeSpan? HANDLE_TIME { get; set; }

        public int? HOLDS { get; set; }

        public TimeSpan? HOLD_TIME { get; set; }

        public bool? IS_COMPLETE { get; set; }

        [StringLength(512)]
        public string IVR_PATH { get; set; }

        public TimeSpan? IVR_TIME { get; set; }

        public DateTime? LAST_MODIFIED { get; set; }

        [Required]
        [StringLength(50)]
        public string LIST_NAME { get; set; }

        public TimeSpan? MANUAL_DIALING_TIME { get; set; }

        public int? MARKETING_SENT_KEY { get; set; }

        [StringLength(512)]
        public string NOTES { get; set; }

        public int? PARKS { get; set; }

        public TimeSpan? PARK_TIME { get; set; }

        public TimeSpan? PREVIEW_TIME { get; set; }

        public int? PRIORITY { get; set; }

        public TimeSpan? QUEUE_WAIT_TIME { get; set; }

        public decimal? RATE { get; set; }

        [Required]
        [StringLength(128)]
        public string RESULT { get; set; }

        public TimeSpan? RING_TIME { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? SERVICE_LEVEL { get; set; }

        [StringLength(100)]
        public string SESSION_ID { get; set; }

        [StringLength(100)]
        public string SKILL { get; set; }

        public TimeSpan? SPEED_OF_ANSWER { get; set; }

        public TimeSpan? TALK_TIME { get; set; }

        public TimeSpan? TALK_TIME_LESS_HOLD_AND_PARK { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        public TimeSpan? THIRD_PARTY_TALK_TIME { get; set; }

        public DateTime? TIME_STAMP { get; set; }

        public int? TRANSFERS { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? WEB_CALL_QUEUE_KEY { get; set; }

        public int? WEB_DIALER_RESULT_TYPE_KEY { get; set; }

        public int? APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? LOCATION { get; set; }

        [StringLength(32)]
        public string MRKT_CAMPAIGN { get; set; }

        public int? QUEUE_TYPE { get; set; }

        [StringLength(32)]
        public string NOBLE_HASH { get; set; }
    }
}
