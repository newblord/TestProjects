namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationProduct")]
    public partial class LoanApplicationProduct
    {
        [Key]
        public int LOAN_APPLICATION_PRODUCT_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        public int? LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int? LOAN_PRODUCT_TILA_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? APPROVED_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SELECTED_AMT { get; set; }

        public bool SELECTED { get; set; }

        public byte? SELECTED_TERM { get; set; }

        public bool? APPROVED { get; set; }

        public string DETAIL { get; set; }

        public DateTime? PRIMARY_SCORE_DATE { get; set; }

        public short? MODEL_USED { get; set; }

        public decimal? FINAL_SCORE { get; set; }

        public int? SCORE_SUMMARY_KEY { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductTila LoanProductTila { get; set; }
    }
}
