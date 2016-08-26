namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleQuote")]
    public partial class VehicleQuote
    {
        [Key]
        public int VEHICLE_QUOTE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(40)]
        public string VIN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MILEAGE_VALUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RETAIL_PRICE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal WHOLESALE_PRICE { get; set; }

        public int MILEAGE { get; set; }

        [Required]
        [StringLength(10)]
        public string PLATE { get; set; }
    }
}
