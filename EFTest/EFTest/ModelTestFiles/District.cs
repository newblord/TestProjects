namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("District")]
    public partial class District
    {
        [Key]
        public short DISTRICT_KEY { get; set; }

        public byte REGION_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string DISTRICT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string DISTRICT_MANAGER { get; set; }

        public virtual Region Region { get; set; }
    }
}
