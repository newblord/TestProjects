using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerEmployer
    {
        public CustomerEmployer()
        {
            CustomerIncome = new HashSet<CustomerIncome>();
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
        }

        public int CustomerEmployerKey { get; set; }
        public int CustomerKey { get; set; }
        public string EmployerName { get; set; }
        public string Department { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public int? AddressKey { get; set; }
        public int? PhoneNumberKey { get; set; }
        public bool IsActive { get; set; }
        public bool IsDirectDeposit { get; set; }
        public bool IsPrimaryEmployer { get; set; }
        public DateTime? EmpSince { get; set; }
        public string Fullparttime { get; set; }
        public string PayCycle { get; set; }
        public byte PayCycleDay { get; set; }
        public byte PayCycle1st { get; set; }
        public byte PayCycle2nd { get; set; }
        public DateTime? BiweekBase { get; set; }
        public string PayCycleMonthInt { get; set; }
        public bool PayCycleCountDaysFromEndOfMonth { get; set; }
        public int IncomeTypeKey { get; set; }
        public int IncomeSourceKey { get; set; }
        public int? IncomeJobTypeKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateInactive { get; set; }
        public string InactiveTeller { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedTeller { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CalcPayDate { get; set; }

        public virtual ICollection<CustomerIncome> CustomerIncome { get; set; }
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
        public virtual CustomerAddress AddressKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual IncomeJobType IncomeJobTypeKeyNavigation { get; set; }
        public virtual IncomeSource IncomeSourceKeyNavigation { get; set; }
        public virtual IncomeType IncomeTypeKeyNavigation { get; set; }
        public virtual CustomerPhoneNumber PhoneNumberKeyNavigation { get; set; }
    }
}
