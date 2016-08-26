namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GalileoResponseCode")]
    public partial class GalileoResponseCode
    {
        [Key]
        public int GALILEO_RESPONSE_CODE_KEY { get; set; }

        public short CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(200)]
        public string DETAIL { get; set; }
    }
}
