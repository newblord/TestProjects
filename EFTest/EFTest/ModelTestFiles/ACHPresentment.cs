namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHPresentment")]
    public partial class ACHPresentment
    {
        [Key]
        public int ACH_PRESENTMENT_KEY { get; set; }

        public int? ACH_PARENT_PRESENTMENT_ID_KEY { get; set; }

        public int ACH_PRESENTMENT_TYPE_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? REFERENCE_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal AMT { get; set; }

        public bool IS_DONE { get; set; }

        public int SCHEDULED_PAYMENT_NUMBER { get; set; }

        public int COLLECTION_PAYMENT_NUMBER { get; set; }

        public int FEE_PAYMENT_NUMBER { get; set; }

        [Required]
        [StringLength(20)]
        public string STATEMENT_ID { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual ACHPresentmentType ACHPresentmentType { get; set; }
    }
}
