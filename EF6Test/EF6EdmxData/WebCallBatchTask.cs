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
    
    public partial class WebCallBatchTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallBatchTask()
        {
            this.WebCallBatchActions = new HashSet<WebCallBatchAction>();
            this.WebCallBatchCriterias = new HashSet<WebCallBatchCriteria>();
        }
    
        public int Web_Call_BatchTask_Key { get; set; }
        public string TaskName { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime Create_Date { get; set; }
        public string Created_By { get; set; }
        public bool AllowScheduling { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallBatchAction> WebCallBatchActions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallBatchCriteria> WebCallBatchCriterias { get; set; }
    }
}