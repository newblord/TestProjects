namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerResponse")]
    public partial class CustomerResponse
    {
        [Key]
        public int CUSTOMER_RESPONSE_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string RESPONSE { get; set; }
    }
}
