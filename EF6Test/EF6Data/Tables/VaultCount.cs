namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultCount")]
    public partial class VaultCount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaultCount()
        {
            CardBatchSettles = new HashSet<CardBatchSettle>();
            OverShorts = new HashSet<OverShort>();
            VaultCountCalcParsedCashes = new HashSet<VaultCountCalcParsedCash>();
            VaultCountEnteredParsedCashes = new HashSet<VaultCountEnteredParsedCash>();
            VaultCountServices = new HashSet<VaultCountService>();
        }

        [Key]
        public int VAULT_COUNT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte START_OF_DAY { get; set; }

        [StringLength(1000)]
        public string OS_REASON { get; set; }

        public int? ENTERED_PARSE_CASH_KEY { get; set; }

        public int? CALC_PARSE_CASH_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal CASHCHK_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal COLLCHK_AMT { get; set; }

        public int CASHCHK_CNT { get; set; }

        public int COLLCHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal CCARD_AMT { get; set; }

        public int CCARD_CNT { get; set; }

        public int? BALSHEET_KEY { get; set; }

        [StringLength(1)]
        public string OS_CATEGORY { get; set; }

        [Column(TypeName = "money")]
        public decimal SPAY_PAYDAY_CHECKS_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal MPAY_PAYDAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal OEND_PAYDAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal SPAY_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal MPAY_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal OEND_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal SPAY_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal MPAY_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal OEND_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal SPAY_SIG_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal MPAY_SIG_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal OEND_SIG_AMT { get; set; }

        public int SPAY_PAYDAY_CHECKS_CNT { get; set; }

        public int MPAY_PAYDAY_CNT { get; set; }

        public int OEND_PAYDAY_CNT { get; set; }

        public int SPAY_TITLE_CNT { get; set; }

        public int MPAY_TITLE_CNT { get; set; }

        public int OEND_TITLE_CNT { get; set; }

        public int SPAY_TITLE_2ND_CNT { get; set; }

        public int MPAY_TITLE_2ND_CNT { get; set; }

        public int OEND_TITLE_2ND_CNT { get; set; }

        public int SPAY_SIG_CNT { get; set; }

        public int MPAY_SIG_CNT { get; set; }

        public int OEND_SIG_CNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BUSINESS_DATE { get; set; }

        public int BAG_MIDDAY_CNT { get; set; }

        public int BAG_MIDDAY_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal BAG_MIDDAY_AMT { get; set; }

        public int BAG_EODAY_CNT { get; set; }

        public int BAG_EODAY_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal BAG_EODAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal SPAY_PAYDAY_DEBIT_CARDS_AMT { get; set; }

        public int SPAY_PAYDAY_DEBIT_CARDS_CNT { get; set; }

        public int GOLD_DAILY_BAGS_CNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_DAILY_BAGS_AMT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardBatchSettle> CardBatchSettles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OverShort> OverShorts { get; set; }

        public virtual ParseCash ParseCash { get; set; }

        public virtual ParseCash ParseCash1 { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountCalcParsedCash> VaultCountCalcParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountEnteredParsedCash> VaultCountEnteredParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountService> VaultCountServices { get; set; }
    }
}
