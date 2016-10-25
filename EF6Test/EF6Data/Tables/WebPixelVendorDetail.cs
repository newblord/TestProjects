namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebPixelVendorDetail")]
    public partial class WebPixelVendorDetail
    {
        [Key]
        public int WEB_PIXEL_VENDOR_DETAIL_KEY { get; set; }

        public int WEB_PIXEL_VENDOR_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string RULE_SET_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string TEST_URL { get; set; }

        [Required]
        [StringLength(100)]
        public string PRODUCTION_URL { get; set; }

        [StringLength(50)]
        public string TEST_USER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCTION_USER_ID { get; set; }

        [StringLength(50)]
        public string TEST_PASSWORD { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCTION_PASSWORD { get; set; }

        [Required]
        [StringLength(100)]
        public string LICENSE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string USER_KEY { get; set; }

        public bool IS_ENABLED { get; set; }

        public virtual WebPixelVendor WebPixelVendor { get; set; }
    }
}
