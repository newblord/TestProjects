namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCategory")]
    public partial class WebCallCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallCategory()
        {
            WebCallCampaignCategories = new HashSet<WebCallCampaignCategory>();
            WebCallWorkItemCategoryHistories = new HashSet<WebCallWorkItemCategoryHistory>();
            WebCallRARRCategoryReasons = new HashSet<WebCallRARRCategoryReason>();
        }

        [Key]
        public int WEB_CALL_CATEGORY_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string CATEGORY { get; set; }

        public short SORT_PRIORITY { get; set; }

        public bool DELETED { get; set; }

        public bool? DIALER_UPLOAD { get; set; }

        public int? DIALER_REFRESH_MINUTES { get; set; }

        public int? COLOR_RGB { get; set; }

        public bool IS_CUJO { get; set; }

        public bool? IS_COLLECTIONS { get; set; }

        public bool? RESET_DAILY { get; set; }

        public DateTime? LAST_RESET_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallCampaignCategory> WebCallCampaignCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallWorkItemCategoryHistory> WebCallWorkItemCategoryHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRARRCategoryReason> WebCallRARRCategoryReasons { get; set; }
    }
}
