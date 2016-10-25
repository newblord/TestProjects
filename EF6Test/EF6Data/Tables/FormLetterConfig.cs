namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterConfig")]
    public partial class FormLetterConfig
    {
        [Key]
        public int FORM_LETTER_CONFIG_KEY { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        [Required]
        [StringLength(66)]
        public string FTP_USERNAME { get; set; }

        [Required]
        [StringLength(66)]
        public string FTP_PASSWORD { get; set; }

        public bool ENABLE_UPLOAD_BATCH { get; set; }

        public bool ENABLE_DOWNLOAD_BATCH { get; set; }

        public bool ENABLE_BATCH_VALIDATION { get; set; }
    }
}
