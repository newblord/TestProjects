namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLeadSale")]
    public partial class WebLeadSale
    {
        [Key]
        public int WEBLEADSALE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        public byte STATUS { get; set; }

        public int LEAD_ID { get; set; }

        public int BUYER_ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string DELIVERY_URL { get; set; }

        [Required]
        [StringLength(255)]
        public string DELIVERY_MSG { get; set; }

        [Required]
        [StringLength(1000)]
        public string ERROR { get; set; }

        public DateTime? LAST_UPDATED_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRICE { get; set; }
    }
}
