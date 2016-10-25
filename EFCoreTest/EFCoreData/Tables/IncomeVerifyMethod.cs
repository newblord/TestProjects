using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeVerifyMethod
    {
        public IncomeVerifyMethod()
        {
            CustomerIncome = new HashSet<CustomerIncome>();
            IncomeVerifyMethodLocation = new HashSet<IncomeVerifyMethodLocation>();
        }

        public int IncomeVerifyMethodKey { get; set; }
        public string VerifyType { get; set; }
        public string VerifyMethod { get; set; }
        public bool IsActive { get; set; }
        public bool ValidatesSteadyIncome { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<CustomerIncome> CustomerIncome { get; set; }
        public virtual ICollection<IncomeVerifyMethodLocation> IncomeVerifyMethodLocation { get; set; }
    }
}
