namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHBank")]
    public partial class ACHBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHBank()
        {
            BanksParents = new HashSet<BanksParent>();
            CompanyACHBanks = new HashSet<CompanyACHBank>();
            CompanyACHBanks1 = new HashSet<CompanyACHBank>();
        }

        [Key]
        public int ACH_BANK_KEY { get; set; }

        [Required]
        [StringLength(255)]
        public string NAME { get; set; }

        public bool IS_INTERNET { get; set; }

        public bool IS_ADASTRA { get; set; }

        [Required]
        [StringLength(6)]
        public string DEBIT_OR_CREDIT { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanksParent> BanksParents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyACHBank> CompanyACHBanks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyACHBank> CompanyACHBanks1 { get; set; }
    }
}
