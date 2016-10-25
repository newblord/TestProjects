namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        public int RECEIPT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RECEIPT_DATA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
