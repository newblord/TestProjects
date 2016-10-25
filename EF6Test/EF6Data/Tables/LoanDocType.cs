namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDocType")]
    public partial class LoanDocType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanDocType()
        {
            LoanDocs = new HashSet<LoanDoc>();
            LoanDocUseds = new HashSet<LoanDocUsed>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte LOAN_DOC_TYPE_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string LOAN_DOC_TYPE_NAME { get; set; }

        [StringLength(5)]
        public string LOAN_DOC_TYPE_ID { get; set; }

        [StringLength(25)]
        public string LOAN_DOC_TYPE_NICKNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDoc> LoanDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDocUsed> LoanDocUseds { get; set; }
    }
}
