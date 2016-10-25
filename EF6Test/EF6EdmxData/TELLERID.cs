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
    
    public partial class TELLERID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TELLERID()
        {
            this.DocumentResources = new HashSet<DocumentResource>();
            this.DocumentResources1 = new HashSet<DocumentResource>();
            this.ReasonForArrears = new HashSet<ReasonForArrear>();
            this.RiUrgentNotes = new HashSet<RiUrgentNote>();
            this.TellerSecurities = new HashSet<TellerSecurity>();
        }
    
        public string TELLER { get; set; }
        public string PASSWORD { get; set; }
        public string FIRSTNAME { get; set; }
        public string LSTNAME { get; set; }
        public Nullable<System.DateTime> LAST_LOGIN { get; set; }
        public short location { get; set; }
        public int SECURITYGROUP_KEY { get; set; }
        public Nullable<System.DateTime> LastPWChg { get; set; }
        public string RSAPassword { get; set; }
        public string SWIPE_ID { get; set; }
        public bool DisplayReleaseInfo { get; set; }
        public string SSN { get; set; }
        public string ADP_ID { get; set; }
        public bool AUDIT_REQUIRED { get; set; }
        public Nullable<System.DateTime> HIRE_DATE { get; set; }
        public Nullable<System.DateTime> CERT_DATE { get; set; }
        public string CERT_BY { get; set; }
        public short LAST_LOCATION { get; set; }
        public bool ACCOUNT_LOCKED { get; set; }
        public byte ATTEMPTS { get; set; }
        public int TELLER_ID_KEY { get; set; }
        public Nullable<int> LAST_SELECTED_CUSTOMER_KEY { get; set; }
        public Nullable<int> LAST_SELECTED_LOAN_KEY { get; set; }
        public string LOCATION_LISTVIEW_COLUMNS { get; set; }
        public string LOCATION_LISTVIEW_COLUMN_WIDTHS { get; set; }
        public string LOCATION_LISTVIEW_SORT { get; set; }
        public bool SHOW_OPS_NEWS { get; set; }
        public byte QUESTION_ATTEMPTS { get; set; }
        public byte TELLER_TYPE { get; set; }
        public Nullable<int> TITLE_KEY { get; set; }
        public string SAM_ACCOUNT_NAME { get; set; }
        public Nullable<System.DateTime> CASHCOUNT_START_DATE { get; set; }
        public Nullable<System.DateTime> CASHCOUNT_END_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentResource> DocumentResources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentResource> DocumentResources1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReasonForArrear> ReasonForArrears { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiUrgentNote> RiUrgentNotes { get; set; }
        public virtual SecurityGroup SecurityGroup { get; set; }
        public virtual SecurityGroup SecurityGroup1 { get; set; }
        public virtual TellerType TellerType { get; set; }
        public virtual TellerTitle TellerTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TellerSecurity> TellerSecurities { get; set; }
    }
}
