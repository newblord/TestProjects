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
    
    public partial class TransferFund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransferFund()
        {
            this.TransferFundsInterStores = new HashSet<TransferFundsInterStore>();
            this.TransferFundsInterStores1 = new HashSet<TransferFundsInterStore>();
        }
    
        public int TRANSFER_FUNDS_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public short LOCATION { get; set; }
        public string FUNDS_FROM { get; set; }
        public string FUNDS_TO { get; set; }
        public int GL_ACCT { get; set; }
        public decimal TOT_AMOUNT { get; set; }
        public string DESCRIPTION { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public int CURRENCY_KEY { get; set; }
    
        public virtual TransDetail TransDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores1 { get; set; }
    }
}