namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EarnedCreditType")]
    public partial class EarnedCreditType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EarnedCreditType()
        {
            CustomerEarnedCredits = new HashSet<CustomerEarnedCredit>();
            DiscountMasters = new HashSet<DiscountMaster>();
        }

        [Key]
        public int EARNED_CREDIT_TYPE_KEY { get; set; }

        [Required]
        [StringLength(15)]
        public string DISPLAY_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public bool IS_ENABLED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPDATED_DATE { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public int ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEarnedCredit> CustomerEarnedCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountMaster> DiscountMasters { get; set; }
    }
}
