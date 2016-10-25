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
    
    public partial class VaultMgrAuthorizationDetail
    {
        public int VM_AUTH_DETAIL_KEY { get; set; }
        public int VM_AUTH_KEY { get; set; }
        public System.DateTime APPROVAL_TIME { get; set; }
        public Nullable<int> MESSAGE_ID { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> TRANS_POS_KEY { get; set; }
        public Nullable<decimal> ORIG_VALUE { get; set; }
        public Nullable<decimal> AUTH_VALUE { get; set; }
        public bool IS_CURRENCY { get; set; }
        public bool IS_PERCENT { get; set; }
        public string MESSAGE_DATA { get; set; }
        public Nullable<bool> IS_VM_AUTH { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual TransPOS TransPOS { get; set; }
        public virtual VaultMgrAuthorization VaultMgrAuthorization { get; set; }
    }
}
