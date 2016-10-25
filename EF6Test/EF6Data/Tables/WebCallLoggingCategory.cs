namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallLoggingCategory")]
    public partial class WebCallLoggingCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallLoggingCategory()
        {
            WebCallLoggingCategoryLogs = new HashSet<WebCallLoggingCategoryLog>();
        }

        [Key]
        public int WEB_CALL_LOGGING_CATEGORY_KEY { get; set; }

        [Required]
        [StringLength(64)]
        public string CATEGORY_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallLoggingCategoryLog> WebCallLoggingCategoryLogs { get; set; }
    }
}
