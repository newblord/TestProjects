namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallLoanProductConfig")]
    public partial class WebCallLoanProductConfig
    {
        [Key]
        public int Web_Call_Loan_Product_Config_Key { get; set; }

        public int Loan_Product_Key { get; set; }

        [Required]
        [StringLength(500)]
        public string Config_Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Config_Value { get; set; }

        public int Display_Order { get; set; }

        public DateTime Date_Entered { get; set; }

        public DateTime Date_Last_Updated { get; set; }

        [Required]
        [StringLength(500)]
        public string Created_By { get; set; }

        [Required]
        [StringLength(500)]
        public string Last_Updated_By { get; set; }

        public bool SupOnly { get; set; }

        [Required]
        [StringLength(100)]
        public string ExternalLinkCaption { get; set; }

        [Required]
        [StringLength(500)]
        public string ExternalLink { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }
    }
}
