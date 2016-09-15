namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SG_RIGHTS
    {
        [Key]
        public int SG_RIGHTS_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string RIGHT_NAME { get; set; }

        public int? PARENT_RIGHTS_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string PARENT_RIGHT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string RIGHT_TYPE { get; set; }

        public int VALUE_POSITION { get; set; }

        [StringLength(50)]
        public string GLOBAL_RIGHT_NAME { get; set; }
    }
}
