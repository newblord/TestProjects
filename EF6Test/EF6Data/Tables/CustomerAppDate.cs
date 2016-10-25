namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAppDate")]
    public partial class CustomerAppDate
    {
        [Key]
        public int CUSTOMER_CERT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime CERT_DATE { get; set; }
    }
}
