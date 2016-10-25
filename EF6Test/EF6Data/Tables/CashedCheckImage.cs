namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheckImage")]
    public partial class CashedCheckImage
    {
        [Key]
        public int CASHED_CHECK_IMAGE_KEY { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        [Required]
        public byte[] DATA { get; set; }

        public short IMAGE_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_TO_DELETE { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }
    }
}
