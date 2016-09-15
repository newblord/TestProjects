namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductBlocked")]
    public partial class LoanProductBlocked
    {
        [Key]
        public int LOAN_PRODUCT_BLOCKED_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SPECIFIC_START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SPECIFIC_END_DATE { get; set; }

        public byte DAY_OF_WEEK { get; set; }

        public byte TYPE_OF_BLOCK { get; set; }

        [Required]
        [StringLength(8)]
        public string BLOCKED_UNTIL_TIME { get; set; }

        [Required]
        [StringLength(8)]
        public string BLOCKED_AFTER_TIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_TO_DELETE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        public short LOCATION { get; set; }

        public virtual Company Company { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
