namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerLeadStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerLeadStatu()
        {
            CustomerLeadActivities = new HashSet<CustomerLeadActivity>();
            CustomerLeadStatusReasons = new HashSet<CustomerLeadStatusReason>();
        }

        [Key]
        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string STATUS { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IN_F2_SEARCH { get; set; }

        public bool IN_QUEUE_MAINT { get; set; }

        public bool REQUIRES_REASON { get; set; }

        public short DISPLAY_ORDER { get; set; }

        public short DELETE_AFTER_DAYS { get; set; }

        public bool REQUIRES_DATE { get; set; }

        public bool REQUIRES_SATELLITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadActivity> CustomerLeadActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerLeadStatusReason> CustomerLeadStatusReasons { get; set; }
    }
}
