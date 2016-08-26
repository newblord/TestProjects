namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolloverRequestDeclineReason")]
    public partial class RolloverRequestDeclineReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolloverRequestDeclineReason()
        {
            RolloverRequests = new HashSet<RolloverRequest>();
        }

        [Key]
        public int ROLLOVER_REQUEST_DECLINE_REASON_KEY { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public bool IS_ENABLED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolloverRequest> RolloverRequests { get; set; }
    }
}
