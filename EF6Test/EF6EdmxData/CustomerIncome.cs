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
    
    public partial class CustomerIncome
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerIncome()
        {
            this.LoanIncomes = new HashSet<LoanIncome>();
        }
    
        public int CUSTOMER_INCOME_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public string AMOUNT_TYPE { get; set; }
        public decimal INCOME_AMOUNT { get; set; }
        public Nullable<int> INCOME_VERIFY_METHOD_KEY { get; set; }
        public Nullable<System.DateTime> DATE_VERIFIED { get; set; }
        public bool IS_DELETED { get; set; }
        public string DELETED_TELLER { get; set; }
        public Nullable<System.DateTime> DATE_DELETED { get; set; }
        public int CUSTOMER_EMPLOYER_KEY { get; set; }
        public string AMOUNT_CYCLE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> DATE_INACTIVE { get; set; }
        public string INACTIVE_TELLER { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual CustomerEmployer CustomerEmployer { get; set; }
        public virtual IncomeVerifyMethod IncomeVerifyMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanIncome> LoanIncomes { get; set; }
    }
}