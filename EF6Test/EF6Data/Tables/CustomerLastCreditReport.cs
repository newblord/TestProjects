namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLastCreditReport")]
    public partial class CustomerLastCreditReport
    {
        [Key]
        public int CUSTOMER_LAST_CREDIT_REPORT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(24)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(25)]
        public string LASTNAME { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
