namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UtilRecalcLogDetail")]
    public partial class UtilRecalcLogDetail
    {
        [Key]
        public int UTIL_RECALC_LOG_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(40)]
        public string TABLE_NAME { get; set; }

        [Required]
        [StringLength(40)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(40)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(40)]
        public string NEW_VALUE { get; set; }
    }
}
