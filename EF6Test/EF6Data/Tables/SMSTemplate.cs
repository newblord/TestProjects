namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSTemplate")]
    public partial class SMSTemplate
    {
        [Key]
        public int SMS_TEMPLATE_KEY { get; set; }

        public int ID { get; set; }

        public int VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(512)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(1024)]
        public string TEMPLATE { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_SYSTEM { get; set; }

        public DateTime DATE_ENTERED { get; set; }
    }
}
