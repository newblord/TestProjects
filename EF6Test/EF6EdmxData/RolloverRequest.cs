//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolloverRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolloverRequest()
        {
            this.LoanApplicationAffordSurvey_ToBeDeleted = new HashSet<LoanApplicationAffordSurvey_ToBeDeleted>();
            this.LoanApplicationExpenses = new HashSet<LoanApplicationExpense>();
        }
    
        public int ROLLOVER_REQUEST_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public byte REQUEST_SOURCE { get; set; }
        public Nullable<short> CC_LAST_FOUR { get; set; }
        public Nullable<int> CREDIT_CARD_KEY { get; set; }
        public Nullable<int> SMS_INBOUND_KEY { get; set; }
        public string ENTERED_BY { get; set; }
        public System.DateTime ENTERED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public bool HAVE_FINANCIALS_CHANGED { get; set; }
        public string DEFERRAL_REASON { get; set; }
        public Nullable<System.DateTime> NEXT_PAY_DATE { get; set; }
        public int ROLLOVER_REQUEST_STATUS_KEY { get; set; }
        public Nullable<int> ROLLOVER_REQUEST_DECLINE_REASON_KEY { get; set; }
    
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
