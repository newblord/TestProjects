namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallQueueLoanAppAudit")]
    public partial class WebCallQueueLoanAppAudit
    {
        [Key]
        public int Web_Call_Queue_LoanAppAudit_Key { get; set; }

        public int Web_Call_Queue_Key { get; set; }

        public int Loan_Application_Key { get; set; }

        public bool? Is_Qualified { get; set; }

        [StringLength(1000)]
        public string Reason_Denied { get; set; }

        public DateTime Date_Created { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }
    }
}
