namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallFAQ")]
    public partial class WebCallFAQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallFAQ()
        {
            WebCallFAQAttachments = new HashSet<WebCallFAQAttachment>();
        }

        [Key]
        public int Web_Call_FAQ_Key { get; set; }

        public int Web_Call_FAQ_Category_Key { get; set; }

        [Required]
        [StringLength(500)]
        public string FAQ_Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FAQ_Content { get; set; }

        public virtual WebCallFAQCategory WebCallFAQCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallFAQAttachment> WebCallFAQAttachments { get; set; }
    }
}
