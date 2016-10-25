namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IPBlock")]
    public partial class IPBlock
    {
        [Key]
        public int IP_Block_Key { get; set; }

        public long NumericIP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateAdded { get; set; }

        public int Hits { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        public bool IsBlocked { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BlockChangeDate { get; set; }

        public string Description { get; set; }
    }
}
