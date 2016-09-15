namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusEmailLocation")]
    public partial class OptPlusEmailLocation
    {
        [Key]
        public int OPTPLUS_EMAIL_LOCATION_KEY { get; set; }

        public int OPTPLUS_EMAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual OptPlusEmail OptPlusEmail { get; set; }
    }
}
