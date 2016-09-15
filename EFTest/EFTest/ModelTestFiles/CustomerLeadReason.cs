namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadReason")]
    public partial class CustomerLeadReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerLeadReason()
        {
            CustomerLeads = new HashSet<CustomerLead>();
            CustomerLeadStatusReasons = new HashSet<CustomerLeadStatusReason>();
        }

        [Key]
        public int CUSTOMER_LEAD_REASON_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string REASON { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLead> CustomerLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadStatusReason> CustomerLeadStatusReasons { get; set; }
    }
}
