namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceDetail")]
    public partial class ServiceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceDetail()
        {
            DrawerServices = new HashSet<DrawerService>();
            DrawerXServices = new HashSet<DrawerXService>();
            DrawerZServices = new HashSet<DrawerZService>();
            GiftCards = new HashSet<GiftCard>();
            LoanServices = new HashSet<LoanService>();
            OverShorts = new HashSet<OverShort>();
            ServiceTrans = new HashSet<ServiceTran>();
            TransDetailServices = new HashSet<TransDetailService>();
            VaultCountServices = new HashSet<VaultCountService>();
            VaultServices = new HashSet<VaultService>();
        }

        [Key]
        public int SERVICE_DETAIL_KEY { get; set; }

        public int SERVICE_MASTER_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SERVICE_COST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SERVICE_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_CHARGE { get; set; }

        public int? GL_ACCT_FEE { get; set; }

        public int? GL_ACCT_AMT { get; set; }

        public int? GL_ACCT_COST { get; set; }

        public int? GL_ACCT_PROFIT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_CHARGE { get; set; }

        public bool GOVT_ID_REQUIRED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerService> DrawerServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerXService> DrawerXServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrawerZService> DrawerZServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiftCard> GiftCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanService> LoanServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OverShort> OverShorts { get; set; }

        public virtual ServiceMaster ServiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTran> ServiceTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailService> TransDetailServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCountService> VaultCountServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultService> VaultServices { get; set; }
    }
}
