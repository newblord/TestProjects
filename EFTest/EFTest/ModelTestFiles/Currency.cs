namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Currency")]
    public partial class Currency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Currency()
        {
            Companies = new HashSet<Company>();
            Countries = new HashSet<Country>();
            CurrencyExchangeConfigs = new HashSet<CurrencyExchangeConfig>();
            Denominations = new HashSet<Denomination>();
            DrawerZCashes = new HashSet<DrawerZCash>();
            TransDetailCashes = new HashSet<TransDetailCash>();
        }

        [Key]
        public int CURRENCY_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENCY_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(1)]
        public string CURRENCY_SYMBOL { get; set; }

        [Required]
        [StringLength(20)]
        public string BILL_DISPLAY { get; set; }

        [Required]
        [StringLength(20)]
        public string GROUPED_COIN_DISPLAY { get; set; }

        public bool IS_ENABLED { get; set; }

        public int ACCT { get; set; }

        public int CASH_TRANSIT_ACCT { get; set; }

        public int OPERATING_ACCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Country> Countries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyExchangeConfig> CurrencyExchangeConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Denomination> Denominations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerZCash> DrawerZCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCash> TransDetailCashes { get; set; }
    }
}
