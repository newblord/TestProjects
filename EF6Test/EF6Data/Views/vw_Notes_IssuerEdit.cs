namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Notes_IssuerEdit
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime NOTEDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(11)]
        public string DESCR { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal DOLLARAMOUNT { get; set; }

        [StringLength(344)]
        public string NOTETEXT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(36)]
        public string TELLERNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string CUSTOM1 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string CUSTOM2 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string CUSTOM3 { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISSUER_KEY { get; set; }
    }
}