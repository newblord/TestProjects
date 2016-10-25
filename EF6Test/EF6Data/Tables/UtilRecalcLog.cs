namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UtilRecalcLog")]
    public partial class UtilRecalcLog
    {
        [Required]
        [StringLength(10)]
        public string RECALC_TYPE { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(50)]
        public string USER_LOGIN { get; set; }

        [Key]
        public int UTIL_RECALC_LOG_KEY { get; set; }
    }
}
