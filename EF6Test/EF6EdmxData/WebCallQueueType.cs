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
    
    public partial class WebCallQueueType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallQueueType()
        {
            this.WebCallQueues = new HashSet<WebCallQueue>();
            this.WebCallWorkQueues = new HashSet<WebCallWorkQueue>();
        }
    
        public int WEB_CALL_QUEUE_TYPE_KEY { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<bool> KEEP_OPEN { get; set; }
        public Nullable<int> POP_PRIORITY { get; set; }
        public Nullable<System.DateTime> DATE_ENTERED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallQueue> WebCallQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueues { get; set; }
    }
}