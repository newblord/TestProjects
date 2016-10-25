using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationEmployer
    {
        public LoanApplicationEmployer()
        {
            LoanApplicationIncome = new HashSet<LoanApplicationIncome>();
        }

        public int LoanApplicationEmployerKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public string EmployerName { get; set; }
        public string Department { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public int? LoanApplicationAddressKey { get; set; }
        public bool? IsDirectDeposit { get; set; }
        public DateTime? EmpSince { get; set; }
        public string Fullparttime { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public string PayCycle { get; set; }
        public byte PayCycleDay { get; set; }
        public byte PayCycle1st { get; set; }
        public byte PayCycle2nd { get; set; }
        public DateTime? BiweekBase { get; set; }
        public string PayCycleMonthInt { get; set; }
        public bool? PayCycleCountDaysFromEndOfMonth { get; set; }
        public int? IncomeTypeKey { get; set; }
        public int? IncomeSourceKey { get; set; }
        public int? IncomeJobTypeKey { get; set; }
        public bool IsPrimaryEmployer { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? JobTypeVerifiedDate { get; set; }
        public int? CustomerEmployerKey { get; set; }

        public virtual ICollection<LoanApplicationIncome> LoanApplicationIncome { get; set; }
        public virtual CustomerEmployer CustomerEmployerKeyNavigation { get; set; }
        public virtual IncomeJobType IncomeJobTypeKeyNavigation { get; set; }
        public virtual IncomeSource IncomeSourceKeyNavigation { get; set; }
        public virtual IncomeType IncomeTypeKeyNavigation { get; set; }
        public virtual LoanApplicationAddress LoanApplicationAddressKeyNavigation { get; set; }
    }
}
