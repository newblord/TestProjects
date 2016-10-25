namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doc10000Trans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doc10000Trans()
        {
            Doc10000TransDetail = new HashSet<Doc10000TransDetail>();
        }

        [Key]
        public int DOC_10000_TRANS_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_IN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_OUT { get; set; }

        public bool CASHED_CHECK { get; set; }

        public byte FORM_TYPE { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doc10000TransDetail> Doc10000TransDetail { get; set; }
    }
}
