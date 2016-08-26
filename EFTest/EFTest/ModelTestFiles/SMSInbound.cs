namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSInbound")]
    public partial class SMSInbound
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMSInbound()
        {
            RolloverRequests = new HashSet<RolloverRequest>();
        }

        [Key]
        public int SMS_INBOUND_KEY { get; set; }

        [StringLength(64)]
        public string SMS_SOURCE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECEIVED_DATE { get; set; }

        [StringLength(50)]
        public string CALLING_FROM_NUMBER { get; set; }

        [StringLength(50)]
        public string CALLING_TO_NUMBER { get; set; }

        [StringLength(128)]
        public string EMAIL_ADDRESS { get; set; }

        [StringLength(800)]
        public string MESSAGE { get; set; }

        public int? SMS_OUTBOUND_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? WEB_CALL_QUEUE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LOCKED_DATE { get; set; }

        public Guid? LOCKED_GUID { get; set; }

        public bool? CLOSED { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolloverRequest> RolloverRequests { get; set; }

        public virtual SMSOutbound SMSOutbound { get; set; }

        public virtual Visitor Visitor { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }
    }
}
