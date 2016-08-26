namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardGroup")]
    public partial class PrepaidCardGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardGroup()
        {
            PrepaidCardBinCompanies = new HashSet<PrepaidCardBinCompany>();
        }

        [Key]
        public int PREPAID_CARD_GROUP_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string GROUP_NAME { get; set; }

        [Required]
        [StringLength(250)]
        public string GROUP_DESCRIPTION { get; set; }

        public int? CARD_AMOUNT_GL_ACCT { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ACTIVE_CHANGED { get; set; }

        [StringLength(3)]
        public string TELLER_ACTIVE_CHANGED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompanies { get; set; }
    }
}
