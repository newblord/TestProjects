namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoanApplicationAffordSurvey_ToBeDeleted
    {
        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? MONTHLY_MORTGAGE { get; set; }

        public int? MONTHLY_UTILITIES { get; set; }

        public int? MONTHLY_OTHER_DEBT { get; set; }

        public int? ROLLOVER_REQUEST_KEY { get; set; }

        [Key]
        public int LOAN_APPLICATION_AFFORD_SURVEY_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? NET_INCOME { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public bool IS_CUSTOMER_REVIEWED { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Visitor Visitor { get; set; }

        public virtual RolloverRequest RolloverRequest { get; set; }
    }
}
