namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanConfigApplyPaymentOrder")]
    public partial class LoanConfigApplyPaymentOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanConfigApplyPaymentOrder()
        {
            LoanProductConfigs = new HashSet<LoanProductConfig>();
        }

        [Key]
        public int LOAN_CONFIG_APPLY_PAYMENT_ORDER_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string APPLY_PAYMENT_ORDER { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfig> LoanProductConfigs { get; set; }
    }
}
