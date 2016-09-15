namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RolloverRequestStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolloverRequestStatu()
        {
            RolloverRequests = new HashSet<RolloverRequest>();
        }

        [Key]
        public int ROLLOVER_REQUEST_STATUS_KEY { get; set; }

        public int ROLLOVER_REQUEST_STATUS_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolloverRequest> RolloverRequests { get; set; }
    }
}
