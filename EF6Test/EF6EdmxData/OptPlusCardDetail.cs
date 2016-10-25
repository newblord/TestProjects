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
    
    public partial class OptPlusCardDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusCardDetail()
        {
            this.FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            this.FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            this.OptPlusCardDetail1 = new HashSet<OptPlusCardDetail>();
            this.OptPlusCardRIPayments = new HashSet<OptPlusCardRIPayment>();
            this.RISREPTs = new HashSet<RISREPT>();
            this.WebCallQueues = new HashSet<WebCallQueue>();
            this.WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
        }
    
        public int OPTPLUS_CARD_DETAIL_KEY { get; set; }
        public int CREDIT_CARD_KEY { get; set; }
        public int OPTPLUS_PRODUCT_KEY { get; set; }
        public bool OVERDRAFT_OPTED_IN { get; set; }
        public decimal OVERDRAFT_AMOUNT { get; set; }
        public bool IS_ELIGIBLE_COLL { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public Nullable<int> ISSUER_KEY { get; set; }
        public Nullable<int> OTHER_CREDITCARD_KEY { get; set; }
        public string CARD_ID { get; set; }
        public Nullable<bool> IS_DEACTIVATED { get; set; }
        public Nullable<int> OPTPLUS_PREVIOUS_PRODUCT_KEY { get; set; }
        public Nullable<decimal> PENDING_COLL_ACH_AMT { get; set; }
        public Nullable<System.DateTime> PENDING_COLL_ACH_SENT { get; set; }
        public Nullable<int> PERSON_ID { get; set; }
        public string PAN_PROXY_NUM { get; set; }
        public Nullable<int> PARENT_OPT_PLUS_CARD_DETAIL_KEY { get; set; }
        public bool IS_EMBOSSED { get; set; }
        public Nullable<System.DateTime> PRODUCT_FLIP_DATE { get; set; }
        public string BANK_ACCESS_NUMBER { get; set; }
    
        public virtual CreditCard CreditCard { get; set; }
        public virtual CreditCard CreditCard1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }
        public virtual Issuer Issuer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetail1 { get; set; }
        public virtual OptPlusCardDetail OptPlusCardDetail2 { get; set; }
        public virtual OptPlusProduct OptPlusProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardRIPayment> OptPlusCardRIPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }
    }
}
