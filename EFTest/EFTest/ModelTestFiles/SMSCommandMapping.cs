namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSCommandMapping")]
    public partial class SMSCommandMapping
    {
        [Key]
        public int SMS_COMMAND_MAPPING_KEY { get; set; }

        [Required]
        [StringLength(32)]
        public string KEYWORD { get; set; }

        [Required]
        [StringLength(16)]
        public string COMMAND { get; set; }
    }
}
