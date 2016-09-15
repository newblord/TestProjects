namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallDualAuth")]
    public partial class WebCallDualAuth
    {
        [Key]
        public int Web_Call_DualAuthId { get; set; }

        public int FeatureId { get; set; }

        public int CustomerId { get; set; }

        public int VisitorId { get; set; }

        public int LoanId { get; set; }

        [Column(TypeName = "money")]
        public decimal? LoanAmount { get; set; }

        [Required]
        [StringLength(50)]
        public string RequestedBy { get; set; }

        [Required]
        [StringLength(50)]
        public string AuthorizedBy { get; set; }

        public DateTime AuthorizedDate { get; set; }
    }
}
