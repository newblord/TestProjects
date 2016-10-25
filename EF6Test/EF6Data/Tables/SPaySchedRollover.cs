namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPaySchedRollover")]
    public partial class SPaySchedRollover
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPaySchedRollover()
        {
            SPaySchedRolloverDetails = new HashSet<SPaySchedRolloverDetail>();
        }

        [Key]
        public int SPAY_SCHED_ROLLOVER_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int ZERO_REC_LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public byte NUM_ROLLOVERS { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPaySchedRolloverDetail> SPaySchedRolloverDetails { get; set; }
    }
}
