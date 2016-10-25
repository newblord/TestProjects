namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreClosed")]
    public partial class StoreClosed
    {
        [Key]
        public int STORECLOSED_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string COMMENT { get; set; }

        public bool BANK { get; set; }

        [Column(TypeName = "date")]
        public DateTime CLOSEDATE { get; set; }
    }
}
