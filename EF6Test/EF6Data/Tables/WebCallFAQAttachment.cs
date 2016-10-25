namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallFAQAttachment")]
    public partial class WebCallFAQAttachment
    {
        [Key]
        public int Web_Call_FAQ_Attachment_Key { get; set; }

        public int Web_Call_FAQ_Key { get; set; }

        [Required]
        public byte[] Attachment { get; set; }

        [Required]
        [StringLength(100)]
        public string Attachment_Name { get; set; }

        public virtual WebCallFAQ WebCallFAQ { get; set; }
    }
}
