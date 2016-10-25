namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadAction")]
    public partial class CustomerLeadAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerLeadAction()
        {
            CustomerLeadActivities = new HashSet<CustomerLeadActivity>();
        }

        [Key]
        public int CUSTOMER_LEAD_ACTION_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string ACTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivities { get; set; }
    }
}
