namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransPOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransPOS()
        {
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTran>();
            TransDetails = new HashSet<TransDetail>();
            VaultMgrAuthorizationDetails = new HashSet<VaultMgrAuthorizationDetail>();
        }

        [Key]
        public int TRANS_POS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_RECV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CCARD_RECV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CCARD_PAID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyExchangeTran> CurrencyExchangeTrans { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetail> TransDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetails { get; set; }
    }
}
