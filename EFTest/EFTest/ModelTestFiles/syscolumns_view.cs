namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscolumns_view
    {
        [StringLength(128)]
        public string name { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte xtype { get; set; }

        public byte? typestat { get; set; }

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

        public short? colid { get; set; }

        public short? xoffset { get; set; }

        public byte? bitpos { get; set; }

        public byte? reserved { get; set; }

        public short? colstat { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cdefault { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int domain { get; set; }

        public short? number { get; set; }

        public short? colorder { get; set; }

        [MaxLength(8000)]
        public byte[] autoval { get; set; }

        public short? offset { get; set; }

        public int? collationid { get; set; }

        public int? language { get; set; }

        public byte? status { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte type { get; set; }

        public short? usertype { get; set; }

        [StringLength(255)]
        public string printfmt { get; set; }

        public short? prec { get; set; }

        public int? scale { get; set; }

        public int? iscomputed { get; set; }

        public int? isoutparam { get; set; }

        public int? isnullable { get; set; }

        [StringLength(128)]
        public string collation { get; set; }

        [MaxLength(5)]
        public byte[] tdscollation { get; set; }
    }
}
