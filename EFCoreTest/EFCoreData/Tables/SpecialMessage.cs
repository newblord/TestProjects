using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpecialMessage
    {
        public SpecialMessage()
        {
            SpecialMessageLoanProduct = new HashSet<SpecialMessageLoanProduct>();
            SpecialMessageLocation = new HashSet<SpecialMessageLocation>();
        }

        public int SpecialMessageKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MessageFile { get; set; }
        public string MessageName { get; set; }
        public string ProcedureName { get; set; }
        public bool ForCashedChecks { get; set; }
        public bool ForServicesNotice { get; set; }
        public bool ForCustomerNotice { get; set; }
        public bool ForGold { get; set; }

        public virtual ICollection<SpecialMessageLoanProduct> SpecialMessageLoanProduct { get; set; }
        public virtual ICollection<SpecialMessageLocation> SpecialMessageLocation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
