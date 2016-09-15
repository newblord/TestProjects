namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityGroup")]
    public partial class SecurityGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityGroup()
        {
            DiscountSecurities = new HashSet<DiscountSecurity>();
            ProcessConfigInstanceGroups = new HashSet<ProcessConfigInstanceGroup>();
            TELLERIDs = new HashSet<TELLERID>();
            TELLERIDs1 = new HashSet<TELLERID>();
        }

        [Key]
        public int SECURITYGROUP_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string SG_NAME { get; set; }

        [Required]
        [StringLength(256)]
        public string SG_VALUES { get; set; }

        public bool IS_COLLECTOR { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_MANAGER { get; set; }

        public bool IS_CORPORATE { get; set; }

        public bool IS_ACCOUNTANT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountSecurity> DiscountSecurities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigInstanceGroup> ProcessConfigInstanceGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELLERID> TELLERIDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELLERID> TELLERIDs1 { get; set; }
    }
}
