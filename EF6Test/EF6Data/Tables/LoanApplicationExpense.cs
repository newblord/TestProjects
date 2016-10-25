namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationExpense")]
    public partial class LoanApplicationExpense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanApplicationExpense()
        {
            LoanApplicationExpenseDetails = new HashSet<LoanApplicationExpenseDetail>();
        }

        [Key]
        public int LOAN_APPLICATION_EXPENSE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public int? ROLLOVER_REQUEST_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        public bool? IS_CUSTOMER_VERIFIED { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual RolloverRequest RolloverRequest { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationExpenseDetail> LoanApplicationExpenseDetails { get; set; }
    }
}
