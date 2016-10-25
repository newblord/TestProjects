namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailCheck")]
    public partial class TransDetailCheck
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_CHECK_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECK_FROM { get; set; }

        [Required]
        [StringLength(1)]
        public string CHECK_TO { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHECK_AMT { get; set; }

        public short CHECK_QTY { get; set; }

        public byte CHECK_TYPE { get; set; }

        public int? DRAWER_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string DEPOSIT_METHOD { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
