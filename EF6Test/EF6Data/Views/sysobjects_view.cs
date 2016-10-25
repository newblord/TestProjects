namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysobjects_view
    {
        [Key]
        [Column(Order = 0)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string xtype { get; set; }

        public short? uid { get; set; }

        public short? info { get; set; }

        public int? status { get; set; }

        public int? base_schema_ver { get; set; }

        public int? replinfo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parent_obj { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime crdate { get; set; }

        public short? ftcatid { get; set; }

        public int? schema_ver { get; set; }

        public int? stats_schema_ver { get; set; }

        [StringLength(2)]
        public string type { get; set; }

        public short? userstat { get; set; }

        public short? sysstat { get; set; }

        public short? indexdel { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime refdate { get; set; }

        public int? version { get; set; }

        public int? deltrig { get; set; }

        public int? instrig { get; set; }

        public int? updtrig { get; set; }

        public int? seltrig { get; set; }

        public int? category { get; set; }

        public short? cache { get; set; }
    }
}
