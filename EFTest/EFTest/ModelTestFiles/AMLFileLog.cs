namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AMLFileLog")]
    public partial class AMLFileLog
    {
        [Key]
        public int AML_LOG_ID { get; set; }

        public int SEQUENCE_NUMBER { get; set; }

        [Required]
        [StringLength(15)]
        public string STREAM { get; set; }

        [Required]
        [StringLength(20)]
        public string STEP { get; set; }

        [Required]
        [StringLength(100)]
        public string FILE_NAME { get; set; }

        public int? NUMBER_OF_RECORDS { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }
    }
}
