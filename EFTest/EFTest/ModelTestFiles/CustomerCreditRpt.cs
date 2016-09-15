namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerCreditRpt")]
    public partial class CustomerCreditRpt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerCreditRpt()
        {
            CustomerCreditRptDetails = new HashSet<CustomerCreditRptDetail>();
        }

        [Key]
        public int CREDIT_RPT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCreditRptDetail> CustomerCreditRptDetails { get; set; }
    }
}
