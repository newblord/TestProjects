namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrawerMaster")]
    public partial class DrawerMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrawerMaster()
        {
            DrawerMasterParsedCashes = new HashSet<DrawerMasterParsedCash>();
            DrawerServices = new HashSet<DrawerService>();
        }

        [Key]
        public int DRAWER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DRAWER_OPENED { get; set; }

        [Column(TypeName = "money")]
        public decimal? DRAWER_MISC { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWER_CCARD { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWER_CHK { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWER_PRA { get; set; }

        public int DRAWER_CHK_CNT { get; set; }

        public int DRAWER_PRA_CNT { get; set; }

        public bool AUDIT_COMPLETED { get; set; }

        public int DRAWER_BAG_CHK_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal DRAWER_BAG_CHK_AMT { get; set; }

        [Column(TypeName = "money")]
        public decimal PRA_DEBIT { get; set; }

        public int PRA_DEBIT_COUNT { get; set; }

        public int DRAWERZ_KEY { get; set; }

        public virtual DrawerZ DrawerZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerMasterParsedCash> DrawerMasterParsedCashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerService> DrawerServices { get; set; }
    }
}
