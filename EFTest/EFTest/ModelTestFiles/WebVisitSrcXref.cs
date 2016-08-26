namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebVisitSrcXref")]
    public partial class WebVisitSrcXref
    {
        [Key]
        public int WebVisitSrcXref_key { get; set; }

        public int? Loan_Key { get; set; }

        public int? Customer_Key { get; set; }

        public int? Loan_Application_Key { get; set; }

        public int? Visitor_Key { get; set; }

        [Required]
        [StringLength(38)]
        public string WebVisit_Session_Guid { get; set; }

        public long WebVisitSource_Key { get; set; }

        [StringLength(50)]
        public string Source_Credit_Category { get; set; }
    }
}
