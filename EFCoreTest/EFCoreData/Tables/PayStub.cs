using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PayStub
    {
        public int PaystubKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public int VisitorKey { get; set; }
        public string CheckNumber { get; set; }
        public decimal CheckAmount { get; set; }
        public DateTime CheckDate { get; set; }
        public string PayType { get; set; }
        public string PayCycle { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public decimal RegularHours { get; set; }
        public decimal RegularRate { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal Gross { get; set; }
        public decimal GrossYtd { get; set; }
        public decimal Taxable { get; set; }
        public decimal FederalTax { get; set; }
        public decimal StateTax { get; set; }
        public decimal SocialSecurityTax { get; set; }
        public decimal MedicareTax { get; set; }
        public DateTime DateEntered { get; set; }
        public int? ImageTransdetailKey { get; set; }

        public virtual TransDetail ImageTransdetailKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
