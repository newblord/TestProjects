namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_Status
    {
        [Key]
        public short CC_STATUS_KEY { get; set; }

        public short STATUS_CODE { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }
    }
}
