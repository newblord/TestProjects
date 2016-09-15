namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlockedAddress")]
    public partial class BlockedAddress
    {
        [Key]
        public int BLOCKED_ADDRESS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string BUILDING_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string STREET_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        public bool ACTIVE { get; set; }

        public bool COMPARE_BUILDING_NAME { get; set; }

        public bool COMPARE_STREET_NAME { get; set; }

        public bool COMPARE_CITY { get; set; }

        public bool COMPARE_ZIPCODE { get; set; }
    }
}
