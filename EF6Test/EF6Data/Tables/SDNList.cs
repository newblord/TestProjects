namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDNList")]
    public partial class SDNList
    {
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Type { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [Key]
        public int SDN_LIST_KEY { get; set; }
    }
}
