namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMgrAuthorization")]
    public partial class VaultMgrAuthorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaultMgrAuthorization()
        {
            VaultMgrAuthorizationNotes = new HashSet<VaultMgrAuthorizationNote>();
            VaultMgrAuthorizationDetails = new HashSet<VaultMgrAuthorizationDetail>();
        }

        [Key]
        public int VM_AUTH_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string LOGGED_ON_INITS { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENT_VM_INITS { get; set; }

        [StringLength(3)]
        public string OTHER_AUTH_INITS { get; set; }

        public DateTime TIME_AUTHORIZED { get; set; }

        [Column(TypeName = "money")]
        public decimal TRANS_AMT { get; set; }

        public int TRANS_RIGHTS_KEY { get; set; }

        public int VMA_TRANS_TYPE_KEY { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationNote> VaultMgrAuthorizationNotes { get; set; }

        public virtual VMATransType VMATransType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetails { get; set; }
    }
}
