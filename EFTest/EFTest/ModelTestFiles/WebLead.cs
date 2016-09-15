namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLead")]
    public partial class WebLead
    {
        [Key]
        public int Web_Lead_Key { get; set; }

        public int Web_Lead_Gen_Key { get; set; }

        public int? Loan_Application_Key { get; set; }

        public int? Attributes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        public DateTime Date_Entered { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinPrice { get; set; }

        public int? SubID { get; set; }

        public bool? Is_Store_Lead { get; set; }

        public int? Customer_Key { get; set; }

        public int? Loan_Key { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
