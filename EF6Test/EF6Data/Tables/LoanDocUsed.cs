namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDocUsed")]
    public partial class LoanDocUsed
    {
        [Key]
        public int LOAN_DOC_USED_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        public bool USE_VEH_STATE { get; set; }

        public int? LOAN_DOC_KEY { get; set; }

        public byte? LOAN_DOC_TYPE_KEY { get; set; }

        public byte PRINT_COPIES { get; set; }

        public bool PRINT_ON_NEW { get; set; }

        public bool PRINT_ON_ROLL_NEW { get; set; }

        public bool PRINT_ON_PAYOFF { get; set; }

        public bool PRINT_ON_CLOSE { get; set; }

        public bool PRINT_ON_WA_PPLAN { get; set; }

        public byte PRINT_ORDER { get; set; }

        public bool PRINT_ON_ROLL_PAID { get; set; }

        public byte PRINT_FOR_LIEN { get; set; }

        [Required]
        [StringLength(1)]
        public string PRINT_FOR_DEPOSIT_METHOD { get; set; }

        public short DAYS_BETWEEN_PRINTING_PER_CUSTOMER { get; set; }

        public bool SCAN_REQUIRED { get; set; }

        public bool PRINT_ON_DENIAL_SRC { get; set; }

        public bool PRINT_ON_DENIAL_STATE { get; set; }

        public bool CLEAR_TITLE_PRESENT { get; set; }

        public bool CLEAR_TITLE_MISSING { get; set; }

        public bool PRINT_FOR_EMAIL_STATEMENTS { get; set; }

        public bool PRINT_FOR_NOT_EMAIL_STATEMENTS { get; set; }

        public bool PRINT_FOR_GIFT_CARDS { get; set; }

        public bool PRINT_FOR_NOT_GIFT_CARDS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_ONLY_LOAN_AMT_MIN { get; set; }

        public short NO_SIGNATURE_ACTION { get; set; }

        public bool ESIGN_ALLOW_SEND_TO_PRINTER { get; set; }

        public bool PRINT_FOR_TITLE_CO_PLEDGER { get; set; }

        public bool PRINT_FOR_TITLE_DUAL_OWNER { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        public virtual LoanDoc LoanDoc { get; set; }

        public virtual LoanDocType LoanDocType { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }
    }
}
