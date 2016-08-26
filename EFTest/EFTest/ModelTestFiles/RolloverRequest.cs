namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolloverRequest")]
    public partial class RolloverRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolloverRequest()
        {
            LoanApplicationAffordSurvey_ToBeDeleted = new HashSet<LoanApplicationAffordSurvey_ToBeDeleted>();
            LoanApplicationExpenses = new HashSet<LoanApplicationExpense>();
        }

        [Key]
        public int ROLLOVER_REQUEST_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public byte REQUEST_SOURCE { get; set; }

        public short? CC_LAST_FOUR { get; set; }

        public int? CREDIT_CARD_KEY { get; set; }

        public int? SMS_INBOUND_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime ENTERED_DATE { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public DateTime? UPDATED_DATE { get; set; }

        public bool HAVE_FINANCIALS_CHANGED { get; set; }

        [StringLength(200)]
        public string DEFERRAL_REASON { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_PAY_DATE { get; set; }

        public int ROLLOVER_REQUEST_STATUS_KEY { get; set; }

        public int? ROLLOVER_REQUEST_DECLINE_REASON_KEY { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationAffordSurvey_ToBeDeleted> LoanApplicationAffordSurvey_ToBeDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationExpense> LoanApplicationExpenses { get; set; }

        public virtual RolloverRequestDeclineReason RolloverRequestDeclineReason { get; set; }

        public virtual RolloverRequestStatu RolloverRequestStatu { get; set; }

        public virtual SMSInbound SMSInbound { get; set; }
    }
}
