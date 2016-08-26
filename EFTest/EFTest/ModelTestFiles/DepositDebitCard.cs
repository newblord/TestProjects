namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositDebitCard")]
    public partial class DepositDebitCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepositDebitCard()
        {
            DepositDebitCardDetails = new HashSet<DepositDebitCardDetail>();
        }

        [Key]
        public int DEPOSIT_DEBIT_CARD_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short DEBIT_CNTR { get; set; }

        [Column(TypeName = "money")]
        public decimal DEBIT_TOT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_TIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_TIME { get; set; }

        public bool COMPLETED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositDebitCardDetail> DepositDebitCardDetails { get; set; }
    }
}
