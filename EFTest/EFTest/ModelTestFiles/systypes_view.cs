namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class systypes_view
    {
        [Key]
        [Column(Order = 0)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte xtype { get; set; }

        public byte? status { get; set; }

        public short? xusertype { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short length { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte xprec { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte xscale { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdefault { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int domain { get; set; }

        public short? uid { get; set; }

        public short? reserved { get; set; }

        public int? collationid { get; set; }

        public short? usertype { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool variable { get; set; }

        public bool? allownulls { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte type { get; set; }

        [StringLength(255)]
        public string printfmt { get; set; }

        public short? prec { get; set; }

        public byte? scale { get; set; }

        [StringLength(128)]
        public string collation { get; set; }
    }
}
