namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerEarnedCredit")]
    public partial class CustomerEarnedCredit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerEarnedCredit()
        {
            EarnedCreditTrans = new HashSet<EarnedCreditTran>();
        }

        [Key]
        public int CUSTOMER_EARNED_CREDIT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int EARNED_CREDIT_TYPE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EXPIRE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_EARNED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_REDEEMED { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual EarnedCreditType EarnedCreditType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarnedCreditTran> EarnedCreditTrans { get; set; }
    }
}
