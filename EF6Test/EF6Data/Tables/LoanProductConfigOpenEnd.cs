namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigOpenEnd")]
    public partial class LoanProductConfigOpenEnd
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_OPEN_END_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACTIVITY_FEE_PCT { get; set; }

        public byte CAB_DEFAULT_LOAN_LENGTH { get; set; }

        public byte CAB_FEE_DAY_OFFSET { get; set; }

        public bool CASH_ADVANCE_DISABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_ADVANCE_LIMIT_AMT { get; set; }

        public bool CASH_ADVANCE_LIMIT_ENABLED { get; set; }

        public short CLOSE_WHEN_INACTIVE_DAYS { get; set; }

        public bool CLOSE_WHEN_PAID_OFF { get; set; }

        public byte COOLING_DAYS_AFTER_FINAL_ROLLOVER { get; set; }

        public byte COOLING_DAYS_CASH_ADVANCE_AFTER_PAYMENT { get; set; }

        public byte CYCLE_DAYS { get; set; }

        public bool FLAT_FEE_BIWEEKLY_RATES_ENABLED { get; set; }

        public bool FLAT_FEE_RULES_ENABLED { get; set; }

        public bool GIFT_CARD_PROCEEDS_ENABLED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENFORCE_ROLLOVER_RESTRICTIONS_AS_OF_DATE { get; set; }

        public bool IS_ORDINANCE_LOCATION { get; set; }

        public bool LIMIT_ZERO_BALANCE_STATEMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_PCT { get; set; }

        public byte NEW_LOAN_WITHIN_CLOSING_PREVIOUS_LOAN_DAYS { get; set; }

        public bool NEW_LOAN_WITHIN_CLOSING_PREVIOUS_LOAN_ONLY_ENABLED { get; set; }

        public short NON_ORDINANCE_LOCATION { get; set; }

        public bool PAY_PRINC_BEFORE_NEXT_AND_NOT_DUE { get; set; }

        public byte PAYMENT_DUE_CYCLE_DAYS { get; set; }

        public bool PRINC_AMT_INCREMENT_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT_INCREMENT_AMT { get; set; }

        public bool STMTS_EMAIL_ENABLED { get; set; }

        public short STMTS_GEN_CYCLE_DAYS { get; set; }

        public bool CASH_ADVANCE_RESCIND_DURING_GRACE_PERIOD_ENABLED { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
