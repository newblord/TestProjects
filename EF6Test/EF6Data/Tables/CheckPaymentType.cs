namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckPaymentType")]
    public partial class CheckPaymentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckPaymentType()
        {
            LoanPaymentCheckPaymentTypeXrefs = new HashSet<LoanPaymentCheckPaymentTypeXref>();
        }

        [Key]
        public int CHECK_PAYMENT_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string TYPE_DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanPaymentCheckPaymentTypeXref> LoanPaymentCheckPaymentTypeXrefs { get; set; }
    }
}
