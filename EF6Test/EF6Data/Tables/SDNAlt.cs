namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDNAlt")]
    public partial class SDNAlt
    {
        public int? ENT_NUM { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALT_NUM { get; set; }

        [StringLength(8)]
        public string ALT_TYPE { get; set; }

        [StringLength(350)]
        public string ALT_NAME { get; set; }

        [StringLength(200)]
        public string ALT_REMARKS { get; set; }

        public virtual SDNMain SDNMain { get; set; }
    }
}
