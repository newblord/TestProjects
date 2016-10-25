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
    
    public partial class WebCallCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallCategory()
        {
            this.WebCallCampaignCategories = new HashSet<WebCallCampaignCategory>();
            this.WebCallWorkItemCategoryHistories = new HashSet<WebCallWorkItemCategoryHistory>();
            this.WebCallRARRCategoryReasons = new HashSet<WebCallRARRCategoryReason>();
        }
    
        public int WEB_CALL_CATEGORY_KEY { get; set; }
        public string CATEGORY { get; set; }
        public short SORT_PRIORITY { get; set; }
        public bool DELETED { get; set; }
        public Nullable<bool> DIALER_UPLOAD { get; set; }
        public Nullable<int> DIALER_REFRESH_MINUTES { get; set; }
        public Nullable<int> COLOR_RGB { get; set; }
        public bool IS_CUJO { get; set; }
        public Nullable<bool> IS_COLLECTIONS { get; set; }
        public Nullable<bool> RESET_DAILY { get; set; }
        public Nullable<System.DateTime> LAST_RESET_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallCampaignCategory> WebCallCampaignCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkItemCategoryHistory> WebCallWorkItemCategoryHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRARRCategoryReason> WebCallRARRCategoryReasons { get; set; }
    }
}
