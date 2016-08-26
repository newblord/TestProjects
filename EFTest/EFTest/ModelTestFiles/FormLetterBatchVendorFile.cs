namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterBatchVendorFile")]
    public partial class FormLetterBatchVendorFile
    {
        [Key]
        public int FORM_LETTER_BATCH_BUILD_VENDOR_FILE_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int FORM_LETTER_KEY { get; set; }

        [StringLength(150)]
        public string FILE_NAME { get; set; }

        public bool UPLOADED { get; set; }
    }
}
