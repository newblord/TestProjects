namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransUnionCode
    {
        [Key]
        public int TUC_KEY { get; set; }

        [Required]
        [StringLength(10)]
        public string tuc_code { get; set; }

        [Required]
        [StringLength(15)]
        public string tuc_type { get; set; }

        [StringLength(200)]
        public string tuc_desc { get; set; }
    }
}
