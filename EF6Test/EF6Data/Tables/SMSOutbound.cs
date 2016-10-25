namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSOutbound")]
    public partial class SMSOutbound
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMSOutbound()
        {
            SMSFailedSends = new HashSet<SMSFailedSend>();
            SMSInbounds = new HashSet<SMSInbound>();
            SMSResponses = new HashSet<SMSResponse>();
        }

        [Key]
        public int SMS_OUTBOUND_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? INITIATED_DATE { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LOCKED_DATE { get; set; }

        public Guid? LOCKED_GUID { get; set; }

        [StringLength(800)]
        public string MESSAGE { get; set; }

        [StringLength(50)]
        public string MOBILE_NUMBER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SENT_DATE { get; set; }

        public int? SMS_SENDER_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSFailedSend> SMSFailedSends { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSInbound> SMSInbounds { get; set; }

        public virtual SMSSender SMSSender { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMSResponse> SMSResponses { get; set; }
    }
}
