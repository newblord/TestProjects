namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallWorkQueue")]
    public partial class WebCallWorkQueue
    {
        [Key]
        public int WEB_CALL_WORK_QUEUE_KEY { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        [StringLength(50)]
        public string WEB_CALL_QUEUE_SESSION_KEY { get; set; }

        public DateTime? ONLINE_CREATED_DATE_TIME { get; set; }

        public DateTime? OFFLINE_CREATED_DATE_TIME { get; set; }

        public int WEB_CALL_QUEUE_CATEGORY_KEY { get; set; }

        public int WEB_CALL_QUEUE_EDITED_CAMPAIGN_KEY { get; set; }

        public int WEB_CALL_QUEUE_ASSIGNED_CAMPAIGN_KEY { get; set; }

        [StringLength(2000)]
        public string PAGE { get; set; }

        public int WEB_CALL_QUEUE_STATUS_KEY { get; set; }

        public bool SUPERVISOR_ESCALLATION { get; set; }

        [Required]
        [StringLength(50)]
        public string CSR { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(150)]
        public string EMAIL_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(15)]
        public string HOME_PHONE { get; set; }

        [Required]
        [StringLength(15)]
        public string CELL_PHONE { get; set; }

        [Required]
        [StringLength(25)]
        public string WORK_PHONE { get; set; }

        public int? WEB_CALL_REASON_KEY { get; set; }

        public int? WEB_CALL_ACTION_KEY { get; set; }

        public int? WEB_CALL_RESULT1_KEY { get; set; }

        public int? WEB_CALL_RESULT2_KEY { get; set; }

        public int? WEB_CALL_RARR_KEY { get; set; }

        [Required]
        [StringLength(4000)]
        public string NOTES { get; set; }

        public DateTime? FOLLOW_UPDATE { get; set; }

        public bool COMPLETED { get; set; }

        public bool CHECKEDOUT { get; set; }

        public Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string WEB_CALL_CHAT_CSR_KEY { get; set; }

        public int? WEB_CALL_LOAN_APP_KEY { get; set; }

        public int? WEB_CALL_CUSTOMER_KEY { get; set; }

        public int? WEB_CALL_VISITOR_KEY { get; set; }

        [StringLength(250)]
        public string WEB_STATUS { get; set; }

        public int? DIALER_STATUS { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? DIALER_CAMPAIGN { get; set; }

        public DateTime? DIALER_DATE { get; set; }

        [StringLength(50)]
        public string WebSource { get; set; }

        public short? Location { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(100)]
        public string LeadId { get; set; }

        [StringLength(5)]
        public string Zipcode { get; set; }

        [StringLength(200)]
        public string Buyer { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SoldAmount { get; set; }

        [StringLength(100)]
        public string FinalScore { get; set; }

        public int? WORK_ITEM_COLOR { get; set; }

        public int? WEB_CALL_QUEUE_TYPE_KEY { get; set; }

        public bool? DD_CONTACT_HR { get; set; }

        public int? DD_CONTACT_ATTEMPTS { get; set; }

        public DateTime? DD_LAST_CONTACT_ATTEMPT_DATE { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? PHONE_COUNT { get; set; }

        public bool? ITSupportEscallation { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        public bool? IS_ONLINE { get; set; }

        [StringLength(50)]
        public string MARKETING_SENT_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        public long? WEB_VISIT_KEY { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail { get; set; }

        public virtual Visitor Visitor { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }

        public virtual WebCallQueueType WebCallQueueType { get; set; }
    }
}
