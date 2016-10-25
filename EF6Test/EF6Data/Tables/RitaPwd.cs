namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RitaPwd")]
    public partial class RitaPwd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string CLIENT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string USER_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USER_PW_SEQ { get; set; }

        [StringLength(64)]
        public string USER_STAT { get; set; }

        [StringLength(24)]
        public string USER_PW { get; set; }
    }
}
