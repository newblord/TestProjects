namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LocationUS_ZipcodesXRef
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string ZIPCODE { get; set; }

        public byte LENDER_KEY { get; set; }

        public bool ENABLED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(50)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(50)]
        public string UPDATED_BY { get; set; }

        public virtual Company Company { get; set; }

        public virtual US_Zipcodes US_Zipcodes { get; set; }
    }
}
