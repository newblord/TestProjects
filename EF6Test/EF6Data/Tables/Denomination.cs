namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Denomination")]
    public partial class Denomination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Denomination()
        {
            Denomination1 = new HashSet<Denomination>();
            DrawerMasterParsedCashes = new HashSet<DrawerMasterParsedCash>();
            TransDetailCashParsedCashes = new HashSet<TransDetailCashParsedCash>();
            VaultCountCalcParsedCashes = new HashSet<VaultCountCalcParsedCash>();
            VaultCountEnteredParsedCashes = new HashSet<VaultCountEnteredParsedCash>();
            VaultMasterParsedCashes = new HashSet<VaultMasterParsedCash>();
        }

        [Key]
        public int DENOMINATION_KEY { get; set; }

        public int CURRENCY_KEY { get; set; }

        public short DISPLAY_SEQUENCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(1)]
        public string DENOMINATION_TYPE { get; set; }

        public int? BASE_DENOMINATION_KEY { get; set; }

        public bool IS_ENABLED { get; set; }

        public virtual Currency Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Denomination> Denomination1 { get; set; }

        public virtual Denomination Denomination2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerMasterParsedCash> DrawerMasterParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCashParsedCash> TransDetailCashParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountCalcParsedCash> VaultCountCalcParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountEnteredParsedCash> VaultCountEnteredParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMasterParsedCash> VaultMasterParsedCashes { get; set; }
    }
}
