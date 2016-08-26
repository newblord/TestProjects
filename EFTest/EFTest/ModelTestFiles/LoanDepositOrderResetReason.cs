namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDepositOrderResetReason")]
    public partial class LoanDepositOrderResetReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanDepositOrderResetReason()
        {
            LoanDepositOrderHistories = new HashSet<LoanDepositOrderHistory>();
        }

        [Key]
        public int LOAN_DEPOSIT_ORDER_RESET_REASON_KEY { get; set; }

        public short REASON { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDepositOrderHistory> LoanDepositOrderHistories { get; set; }
    }
}
