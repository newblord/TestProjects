namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OCRRegion")]
    public partial class OCRRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OCRRegion()
        {
            BillerOCRRegions = new HashSet<BillerOCRRegion>();
        }

        [Key]
        public int OCRREGION_KEY { get; set; }

        public byte SNIPPET { get; set; }

        public bool ENABLE { get; set; }

        public bool FRONT { get; set; }

        public bool MILLIMETERS { get; set; }

        public short X { get; set; }

        public short Y { get; set; }

        public short WIDTH { get; set; }

        public short HEIGHT { get; set; }

        public byte ORIENTATION { get; set; }

        public byte COLOR { get; set; }

        public byte SIDE { get; set; }

        public short OCRFLAGS { get; set; }

        public byte COMPRESSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillerOCRRegion> BillerOCRRegions { get; set; }
    }
}
