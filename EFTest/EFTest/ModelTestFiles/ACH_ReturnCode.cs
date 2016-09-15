namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACH_ReturnCode
    {
        [Key]
        public int ACH_RETCODE_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ACH_RETCODE { get; set; }

        [StringLength(60)]
        public string RETCODE_SHORT { get; set; }

        [StringLength(255)]
        public string RETCODE_LONG { get; set; }

        public int RIS_Type_Id { get; set; }
    }
}
