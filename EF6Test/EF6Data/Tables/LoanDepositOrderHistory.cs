namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDepositOrderHistory")]
    public partial class LoanDepositOrderHistory
    {
        [Key]
        public int LOAN_DEPOSIT_ORDER_HISTORY_KEY { get; set; }

        public int? RULE_DEF_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte OLD_DEPOSIT_ORDER { get; set; }

        public byte NEW_DEPOSIT_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public int? RESET_REASON_KEY { get; set; }

        public virtual LoanDepositOrderResetReason LoanDepositOrderResetReason { get; set; }

        public virtual RuleDef RuleDef { get; set; }
    }
}
