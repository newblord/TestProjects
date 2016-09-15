namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialMessage")]
    public partial class SpecialMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialMessage()
        {
            SpecialMessageLoanProducts = new HashSet<SpecialMessageLoanProduct>();
            SpecialMessageLocations = new HashSet<SpecialMessageLocation>();
        }

        [Key]
        public int SPECIAL_MESSAGE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_DATE { get; set; }

        [Column(TypeName = "text")]
        public string MESSAGE_FILE { get; set; }

        [Required]
        [StringLength(50)]
        public string MESSAGE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PROCEDURE_NAME { get; set; }

        public bool FOR_CASHED_CHECKS { get; set; }

        public bool FOR_SERVICES_NOTICE { get; set; }

        public bool FOR_CUSTOMER_NOTICE { get; set; }

        public bool FOR_GOLD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialMessageLoanProduct> SpecialMessageLoanProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialMessageLocation> SpecialMessageLocations { get; set; }
    }
}
