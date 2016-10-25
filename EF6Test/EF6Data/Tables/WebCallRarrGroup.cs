namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRarrGroup")]
    public partial class WebCallRarrGroup
    {
        [Key]
        public int Web_Call_Rarr_Group_KEY { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public bool DELETED { get; set; }

        public int? Points { get; set; }

        public int RarrCountOffset { get; set; }
    }
}
