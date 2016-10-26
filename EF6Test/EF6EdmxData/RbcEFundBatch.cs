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
    
    public partial class RbcEFundBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RbcEFundBatch()
        {
            this.RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
            this.RbcEFundBatchSummaries = new HashSet<RbcEFundBatchSummary>();
        }
    
        public int RBC_EFUND_BATCH_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public short DETAIL_COUNT { get; set; }
        public decimal DETAIL_VALUE { get; set; }
        public Nullable<System.DateTime> RESPONSE_DATE { get; set; }
        public string SEND_FILE_NAME { get; set; }
        public bool FILE_WRITTEN { get; set; }
        public bool ACCEPTED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchSummary> RbcEFundBatchSummaries { get; set; }
    }
}