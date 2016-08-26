namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransferFund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransferFund()
        {
            TransferFundsInterStores = new HashSet<TransferFundsInterStore>();
            TransferFundsInterStores1 = new HashSet<TransferFundsInterStore>();
        }

        [Key]
        public int TRANSFER_FUNDS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string FUNDS_FROM { get; set; }

        [Required]
        [StringLength(1)]
        public string FUNDS_TO { get; set; }

        public int GL_ACCT { get; set; }

        [Column(TypeName = "money")]
        public decimal TOT_AMOUNT { get; set; }

        [Required]
        [StringLength(80)]
        public string DESCRIPTION { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int CURRENCY_KEY { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferFundsInterStore> TransferFundsInterStores1 { get; set; }
    }
}
