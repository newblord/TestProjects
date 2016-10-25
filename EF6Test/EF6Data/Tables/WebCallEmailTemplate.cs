namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallEmailTemplate
    {
        [Key]
        public int Web_Call_EmailTemplate_Key { get; set; }

        [Required]
        [StringLength(100)]
        public string Template_Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Template_Description { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public bool Is_Body_Html { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public bool IS_ACTIVE { get; set; }
    }
}
