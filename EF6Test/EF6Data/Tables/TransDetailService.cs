namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailService")]
    public partial class TransDetailService
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_SERVICE_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public int? TRANS_DETAIL_ACCT_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string SERVICE_FROM { get; set; }

        [Required]
        [StringLength(1)]
        public string SERVICE_TO { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int SERVICE_QTY { get; set; }

        public int? DRAWER_KEY { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
