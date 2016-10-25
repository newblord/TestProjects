namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMaster")]
    public partial class VaultMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaultMaster()
        {
            VaultMasterParsedCashes = new HashSet<VaultMasterParsedCash>();
        }

        [Key]
        public int VAULT_KEY { get; set; }

        public short LOCATION { get; set; }

        [StringLength(3)]
        public string VAULT_MGR { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_100 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_50 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_20 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_05 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_01 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_HLF { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_QTR { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_DIME { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_NIC { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_PEN { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_MISC { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_CASHCHK_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_CCARD_AMT { get; set; }

        public short VAULT_CASHCHK_CNT { get; set; }

        public short? VAULT_CCARD_CNT { get; set; }

        public bool MGR_AUDIT_COMPLETE { get; set; }

        public bool VMGR_AUDIT_COMPLETE { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_MPAY_PAYDAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_OEND_PAYDAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_SPAY_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_MPAY_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_OEND_TITLE_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_SPAY_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_MPAY_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_OEND_TITLE_2ND_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_SPAY_SIG_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_MPAY_SIG_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_OEND_SIG_AMT { get; set; }

        public short VAULT_MPAY_PAYDAY_CNT { get; set; }

        public short VAULT_OEND_PAYDAY_CNT { get; set; }

        public short VAULT_SPAY_TITLE_CNT { get; set; }

        public short VAULT_MPAY_TITLE_CNT { get; set; }

        public short VAULT_OEND_TITLE_CNT { get; set; }

        public short VAULT_SPAY_TITLE_2ND_CNT { get; set; }

        public short VAULT_MPAY_TITLE_2ND_CNT { get; set; }

        public short VAULT_OEND_TITLE_2ND_CNT { get; set; }

        public short VAULT_SPAY_SIG_CNT { get; set; }

        public short VAULT_MPAY_SIG_CNT { get; set; }

        public short VAULT_OEND_SIG_CNT { get; set; }

        public short VAULT_BAG_MIDDAY_CNT { get; set; }

        public short VAULT_BAG_MIDDAY_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_BAG_MIDDAY_AMT { get; set; }

        public short VAULT_BAG_EODAY_CNT { get; set; }

        public short VAULT_BAG_EODAY_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_BAG_EODAY_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_SPAY_PAYDAY_CHECKS_AMT { get; set; }

        public short VAULT_SPAY_PAYDAY_CHECKS_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal VAULT_SPAY_PAYDAY_DEBIT_CARDS_AMT { get; set; }

        public int VAULT_SPAY_PAYDAY_DEBIT_CARDS_CNT { get; set; }

        public short VAULT_GOLD_DAILY_BAGS_CNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VAULT_GOLD_DAILY_BAGS_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_2P { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_20P { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAULT_02 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Vault_Tot_Cash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMasterParsedCash> VaultMasterParsedCashes { get; set; }
    }
}
