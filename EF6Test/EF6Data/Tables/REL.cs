namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RELS")]
    public partial class REL
    {
        [Key]
        [StringLength(1)]
        public string RelCode { get; set; }

        [StringLength(50)]
        public string RelDesc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RELS_KEY { get; set; }
    }
}
