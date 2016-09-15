namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParseCash")]
    public partial class ParseCash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParseCash()
        {
            TransDetailCashes = new HashSet<TransDetailCash>();
            VaultCounts = new HashSet<VaultCount>();
            VaultCounts1 = new HashSet<VaultCount>();
        }

        [Key]
        public int PARSE_CASH_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal PC_100 { get; set; }

        [Column(TypeName = "money")]
        public decimal PC_50 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_20 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_10 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_05 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_01 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_HLF { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_QTR { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_DIME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_NIC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_PEN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_HLF { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_QTR { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_DIME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_NIC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_PEN { get; set; }

        [Column(TypeName = "money")]
        public decimal PC_MISC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_02 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_01 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_2P { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_ROLL_20P { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_01 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_02 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_2P { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PC_LOOSE_20P { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PC_TOT_CASH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCash> TransDetailCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCount> VaultCounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCount> VaultCounts1 { get; set; }
    }
}
