namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallFAQCategory")]
    public partial class WebCallFAQCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallFAQCategory()
        {
            WebCallFAQs = new HashSet<WebCallFAQ>();
        }

        [Key]
        public int Web_Call_FAQ_Category_Key { get; set; }

        [Required]
        [StringLength(150)]
        public string FAQ_Category_Description { get; set; }

        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallFAQ> WebCallFAQs { get; set; }
    }
}
