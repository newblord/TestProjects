namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class US_Zipcodes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public US_Zipcodes()
        {
            LocationUS_ZipcodesXRef = new HashSet<LocationUS_ZipcodesXRef>();
        }

        [Key]
        [StringLength(7)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(50)]
        public string COUNTY { get; set; }

        public short TIMEZONE { get; set; }

        [StringLength(4)]
        public string MSA_CODE { get; set; }

        [StringLength(5)]
        public string ZIP_TYPE { get; set; }

        public int? DMA { get; set; }

        public decimal? latitude { get; set; }

        public decimal? longitude { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationUS_ZipcodesXRef> LocationUS_ZipcodesXRef { get; set; }

        public virtual MSA MSA { get; set; }
    }
}
