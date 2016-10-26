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
    
    public partial class CustomerLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerLead()
        {
            this.CustomerLeadActivities = new HashSet<CustomerLeadActivity>();
            this.CustomerLeadNotes = new HashSet<CustomerLeadNote>();
        }
    
        public int CUSTOMER_LEAD_KEY { get; set; }
        public Nullable<System.DateTime> DATE_ENTERED { get; set; }
        public string LEAD_SOURCE { get; set; }
        public short ORIG_LOCATION { get; set; }
        public short SUPERSTORE { get; set; }
        public Nullable<short> SATELLITE { get; set; }
        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }
        public System.DateTime STATUS_CHANGE_DATE { get; set; }
        public Nullable<int> CUSTOMER_LEAD_REASON_KEY { get; set; }
        public int LOAN_APPLICATION_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDNAME { get; set; }
        public string LASTNAME { get; set; }
        public string SSN { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string HOME_ADDR_NUM { get; set; }
        public string HOME_ADDR_PRE_DIR { get; set; }
        public string HOME_ADDR_STREET { get; set; }
        public string HOME_ADDR_SUFFIX { get; set; }
        public string HOME_ADDR_POST_DIR { get; set; }
        public string HOME_ADDR_SUITE { get; set; }
        public string HOME_ADDR_SUITE_NUM { get; set; }
        public string HOME_CITY { get; set; }
        public string HOME_STATE { get; set; }
        public string HOME_ZIPCODE { get; set; }
        public Nullable<System.DateTime> RESIDENCE_SINCE { get; set; }
        public Nullable<byte> OWNRENTOTHER { get; set; }
        public string HOME_PHONE { get; set; }
        public string CELL_PHONE { get; set; }
        public Nullable<int> MOBILE_CARRIER { get; set; }
        public string WORK_PHONE { get; set; }
        public string WORK_PHONE_EXT { get; set; }
        public string PREFERRED_CONTACT { get; set; }
        public string EMAIL { get; set; }
        public string PAY_CYCLE { get; set; }
        public Nullable<decimal> GROSS_INCOME { get; set; }
        public Nullable<decimal> NET_INCOME { get; set; }
        public Nullable<decimal> PVBD_INCOME { get; set; }
        public string ABA_NUM { get; set; }
        public string ACCT_NO { get; set; }
        public Nullable<System.DateTime> APPT_FOLLOW_DATE { get; set; }
        public string APPT_FOLLOW_TIME { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public string TELLER_UPDATED { get; set; }
        public Nullable<int> VISITOR_KEY { get; set; }
        public string HOME_ADDRESS_LINE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivities { get; set; }
        public virtual CustomerLeadReason CustomerLeadReason { get; set; }
        public virtual LoanApplication LoanApplication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadNote> CustomerLeadNotes { get; set; }
    }
}