namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLeadGenAddress")]
    public partial class WebLeadGenAddress
    {
        [Key]
        public int WEB_LEAD_GEN_ADDRESS_KEY { get; set; }

        public int WEB_LEAD_GEN_KEY { get; set; }

        [Required]
        [StringLength(150)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(20)]
        public string PHONE_NUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string EMAIL_ADDRESS { get; set; }

        [Required]
        [StringLength(20)]
        public string FAX_NUMBER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
