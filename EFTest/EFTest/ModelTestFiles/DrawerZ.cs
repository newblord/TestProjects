namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerZ")]
    public partial class DrawerZ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrawerZ()
        {
            DrawerMasters = new HashSet<DrawerMaster>();
            DrawerZCashes = new HashSet<DrawerZCash>();
            DrawerZServices = new HashSet<DrawerZService>();
            OverShorts = new HashSet<OverShort>();
            TransDetails = new HashSet<TransDetail>();
        }

        [Key]
        public int DRAWERZ_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWERZ_CHK { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWERZ_PRA { get; set; }

        public int DRAWERZ_CHK_CNT { get; set; }

        public int DRAWERZ_PRA_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWERZ_MISC { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWERZ_CCARD { get; set; }

        [Column(TypeName = "money")]
        public decimal CNTZ_MISC { get; set; }

        [Column(TypeName = "money")]
        public decimal CNTZ_CCARD { get; set; }

        [StringLength(1000)]
        public string OS_REASON { get; set; }

        [StringLength(1)]
        public string OS_CATEGORY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DRAWER_OPENED { get; set; }

        public int DRAWERZ_BAG_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWERZ_BAG_CHK_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal PRA_DEBIT { get; set; }

        public int PRA_DEBIT_COUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerMaster> DrawerMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerZCash> DrawerZCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerZService> DrawerZServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OverShort> OverShorts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetail> TransDetails { get; set; }
    }
}
