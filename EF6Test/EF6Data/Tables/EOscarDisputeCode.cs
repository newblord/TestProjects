namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EOscarDisputeCode")]
    public partial class EOscarDisputeCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EOscarDisputeCode()
        {
            EOscarDetailDisputeCodes = new HashSet<EOscarDetailDisputeCode>();
        }

        [Key]
        public int EOSCAR_DISPUTE_CODE_KEY { get; set; }

        [Required]
        [StringLength(5)]
        public string DISPUTE_CODE { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        public bool MANUAL_PROCESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EOscarDetailDisputeCode> EOscarDetailDisputeCodes { get; set; }
    }
}
