namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebPixelVendor")]
    public partial class WebPixelVendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebPixelVendor()
        {
            WebPixelVendorDatas = new HashSet<WebPixelVendorData>();
            WebPixelVendorDetails = new HashSet<WebPixelVendorDetail>();
        }

        [Key]
        public int WPV_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorName { get; set; }

        public bool Enabled { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public bool UseNumericScore { get; set; }

        [Required]
        [StringLength(3)]
        public string NumericPassScore { get; set; }

        [Required]
        [StringLength(3)]
        public string NumericWarnScore { get; set; }

        [Required]
        [StringLength(3)]
        public string NumericFailScore { get; set; }

        public bool AlphaPassOnUnknown { get; set; }

        [Required]
        [StringLength(10)]
        public string AlphaPassScore { get; set; }

        [Required]
        [StringLength(10)]
        public string AlphaWarnScore { get; set; }

        [Required]
        [StringLength(10)]
        public string AlphaFailScore { get; set; }

        [StringLength(200)]
        public string PROXY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebPixelVendorData> WebPixelVendorDatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebPixelVendorDetail> WebPixelVendorDetails { get; set; }
    }
}
