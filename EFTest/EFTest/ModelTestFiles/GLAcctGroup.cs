namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GLAcctGroup")]
    public partial class GLAcctGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GLAcctGroup()
        {
            Companies = new HashSet<Company>();
        }

        [Key]
        public int GL_ACCT_GROUP_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string GROUP_NAME { get; set; }

        public int? CCARD_SUSPENSE_ACCT { get; set; }

        public int? CCARD_COLL_ACCT { get; set; }

        public int? CASHED_CHECK_CAN_USD_ACCT { get; set; }

        public int? LOANS_PRIMARY_BANK_ACCT { get; set; }

        public int? CHECKS_PRIMARY_BANK_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_INVENTORY_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_FEES_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_RI_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_COLL_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_CAB_FEE_RECV_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_CAB_RI_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_CAB_COLL_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_REBATE_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_DISCOUNT_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_LEGAL_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_NSF_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_INTEREST_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_ROLLOVER_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_INVENTORY_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_FEES_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_RI_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_COLL_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_CAB_FEE_RECV_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_CAB_RI_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_CAB_COLL_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_FUNDING_SUSPENSE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_REBATE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_DISCOUNT_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_LEGAL_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_NSF_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_INTEREST_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_ROLLOVER_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? SPAY_PAYDAY_PAD_BANK_CLEARING_ACCT { get; set; }

        public int? SPAY_PAYDAY_EFT_COLLECTIONS_CLEARING_ACCT { get; set; }

        public int? SPAY_PAYDAY_BAD_DEBT_ACCT { get; set; }

        public int? SPAY_PAYDAY_ROLLOVER_SUSPENSE_ACCT { get; set; }

        public int? SPAY_PAYDAY_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? SPAY_TITLE_INVENTORY_ACCT { get; set; }

        public int? SPAY_TITLE_FEES_ACCT { get; set; }

        public int? SPAY_TITLE_LIEN_ACCT { get; set; }

        public int? SPAY_TITLE_TRANS_ACCT { get; set; }

        public int? SPAY_TITLE_DEF_ACCT { get; set; }

        public int? SPAY_TITLE_COLL_ACCT { get; set; }

        public int? SPAY_TITLE_CAB_FEE_RECV_ACCT { get; set; }

        public int? SPAY_TITLE_CAB_DEF_ACCT { get; set; }

        public int? SPAY_TITLE_CAB_COLL_ACCT { get; set; }

        public int? SPAY_TITLE_SURCH_ACCT { get; set; }

        public int? SPAY_TITLE_LEGAL_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_NSF_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_INTEREST_ACCT { get; set; }

        public int? SPAY_TITLE_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_ROLLOVER_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_INVENTORY_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_FEES_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_LIEN_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_TRANS_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_DEF_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_COLL_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_CAB_FEE_RECV_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_CAB_DEF_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_CAB_COLL_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_SURCH_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_LEGAL_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_NSF_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_INTEREST_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_ROLLOVER_FEE_ACCT { get; set; }

        public int? SPAY_SIG_INVENTORY_ACCT { get; set; }

        public int? SPAY_SIG_FEES_ACCT { get; set; }

        public int? SPAY_SIG_TRANS_ACCT { get; set; }

        public int? SPAY_SIG_DEF_ACCT { get; set; }

        public int? SPAY_SIG_COLL_ACCT { get; set; }

        public int? SPAY_SIG_CAB_FEE_RECV_ACCT { get; set; }

        public int? SPAY_SIG_CAB_DEF_ACCT { get; set; }

        public int? SPAY_SIG_CAB_COLL_ACCT { get; set; }

        public int? SPAY_SIG_LEGAL_FEE_ACCT { get; set; }

        public int? SPAY_SIG_NSF_FEE_ACCT { get; set; }

        public int? SPAY_SIG_INTEREST_ACCT { get; set; }

        public int? SPAY_SIG_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? SPAY_SIG_ROLLOVER_FEE_ACCT { get; set; }

        public int? SPAY_SIG_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? MPAY_BL_TAX_PREP_INV_ACCT { get; set; }

        public int? MPAY_BL_TAX_PREP_REV_ACCT { get; set; }

        public int? MPAY_BL_INVENTORY_ACCT { get; set; }

        public int? MPAY_BL_FEES_ACCT { get; set; }

        public int? MPAY_BL_RI_ACCT { get; set; }

        public int? MPAY_BL_COLL_ACCT { get; set; }

        public int? MPAY_BL_FUNDING_SUSPENSE_ACCT { get; set; }

        public int? MPAY_BL_LEGAL_FEES_ACCT { get; set; }

        public int? MPAY_BL_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? MPAY_BL_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_BL_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_BL_CAB_DEF_ACCT { get; set; }

        public int? MPAY_BL_CAB_COLL_ACCT { get; set; }

        public int? MPAY_BL_NSF_FEE_ACCT { get; set; }

        public int? MPAY_BL_INTEREST_ACCT { get; set; }

        public int? MPAY_BL_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? MPAY_BL_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? MPAY_BL_CAB_LENDER_RI_FEE_ACCT { get; set; }

        public int? MPAY_BL_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? MPAY_TITLE_INVENTORY_ACCT { get; set; }

        public int? MPAY_TITLE_FEES_ACCT { get; set; }

        public int? MPAY_TITLE_LIEN_ACCT { get; set; }

        public int? MPAY_TITLE_TRANS_ACCT { get; set; }

        public int? MPAY_TITLE_DEF_ACCT { get; set; }

        public int? MPAY_TITLE_COLL_ACCT { get; set; }

        public int? MPAY_TITLE_FUNDING_SUSPENSE_ACCT { get; set; }

        public int? MPAY_TITLE_LEGAL_FEES_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_DEF_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_COLL_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? MPAY_TITLE_CAB_LENDER_RI_FEE_ACCT { get; set; }

        public int? MPAY_TITLE_NSF_FEE_ACCT { get; set; }

        public int? MPAY_TITLE_INTEREST_ACCT { get; set; }

        public int? MPAY_TITLE_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? MPAY_TITLE_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_INVENTORY_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_FEES_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_LIEN_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_TRANS_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_DEF_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_COLL_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_NSF_FEE_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_INTEREST_ACCT { get; set; }

        public int? MPAY_TITLE_2ND_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? MPAY_SIG_INVENTORY_ACCT { get; set; }

        public int? MPAY_SIG_FEES_ACCT { get; set; }

        public int? MPAY_SIG_TRANS_ACCT { get; set; }

        public int? MPAY_SIG_DEF_ACCT { get; set; }

        public int? MPAY_SIG_COLL_ACCT { get; set; }

        public int? MPAY_SIG_LEGAL_FEES_ACCT { get; set; }

        public int? MPAY_SIG_TAX_ACCT { get; set; }

        public int? MPAY_SIG_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? MPAY_SIG_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_SIG_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? MPAY_SIG_CAB_DEF_ACCT { get; set; }

        public int? MPAY_SIG_CAB_COLL_ACCT { get; set; }

        public int? MPAY_SIG_NSF_FEE_ACCT { get; set; }

        public int? MPAY_SIG_INTEREST_ACCT { get; set; }

        public int? MPAY_SIG_FASTER_PAYMENTS_FEE_ACCT { get; set; }

        public int? MPAY_SIG_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? OEND_BL_INVENTORY_ACCT { get; set; }

        public int? OEND_BL_TRANS_FEE_ACCT { get; set; }

        public int? OEND_BL_ACTIVITY_FEE_ACCT { get; set; }

        public int? OEND_BL_INTEREST_ACCT { get; set; }

        public int? OEND_BL_RI_ACCT { get; set; }

        public int? OEND_BL_COLL_ACCT { get; set; }

        public int? OEND_BL_CAB_RI_ACCT { get; set; }

        public int? OEND_BL_CAB_COLL_ACCT { get; set; }

        public int? OEND_BL_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? OEND_BL_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_BL_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_BL_CAB_FEE_RECEIVABLE_ACCT { get; set; }

        public int? OEND_BL_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? OEND_BL_CAB_LENDER_RI_FEE_ACCT { get; set; }

        public int? OEND_BL_DISCOUNT_ACCT { get; set; }

        public int? OEND_BL_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? OEND_TITLE_INVENTORY_ACCT { get; set; }

        public int? OEND_TITLE_FEES_ACCT { get; set; }

        public int? OEND_TITLE_LIEN_ACCT { get; set; }

        public int? OEND_TITLE_TRANS_ACCT { get; set; }

        public int? OEND_TITLE_DEF_ACCT { get; set; }

        public int? OEND_TITLE_COLL_ACCT { get; set; }

        public int? OEND_TITLE_CAB_DEF_ACCT { get; set; }

        public int? OEND_TITLE_CAB_COLL_ACCT { get; set; }

        public int? OEND_TITLE_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? OEND_TITLE_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_TITLE_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_TITLE_CAB_FEE_RECEIVABLE_ACCT { get; set; }

        public int? OEND_TITLE_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? OEND_TITLE_CAB_LENDER_RI_FEE_ACCT { get; set; }

        public int? OEND_TITLE_DISCOUNT_ACCT { get; set; }

        public int? OEND_TITLE_ADASTRA_BAD_DEBT_ACCT { get; set; }

        public int? OEND_TITLE_2ND_INVENTORY_ACCT { get; set; }

        public int? OEND_TITLE_2ND_FEES_ACCT { get; set; }

        public int? OEND_TITLE_2ND_LIEN_ACCT { get; set; }

        public int? OEND_TITLE_2ND_TRANS_ACCT { get; set; }

        public int? OEND_TITLE_2ND_DEF_ACCT { get; set; }

        public int? OEND_TITLE_2ND_COLL_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_DEF_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_COLL_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_DUE_TO_LENDER_SUSPENSE_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_UNCOLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_COLLECTED_ACCRUED_INTEREST_ACCT { get; set; }

        public int? OEND_TITLE_2ND_CAB_FEE_RECEIVABLE_ACCT { get; set; }

        public int? OEND_TITLE_2ND_DISCOUNT_ACCT { get; set; }

        public int? RETURN_CHECK_PAYDAY_CHECKS_ACCT { get; set; }

        public int? RETURN_CHECK_CASHED_CHECKS_ACCT { get; set; }

        public int? SPAY_PAYDAY_DECREASE_ACCT { get; set; }

        public int? SPAY_TITLE_DECREASE_ACCT { get; set; }

        public int? MPAY_BL_DECREASE_ACCT { get; set; }

        public int? MPAY_SIG_DECREASE_ACCT { get; set; }

        public int? MPAY_TITLE_DECREASE_ACCT { get; set; }

        public int? OEND_BL_DECREASE_ACCT { get; set; }

        public int? OEND_TITLE_DECREASE_ACCT { get; set; }

        public int? ACH_SUSPENSE_ACCT { get; set; }

        public int? ACH_COLL_ACCT { get; set; }

        public int? MPAY_BL_INSURANCE_REVENUE_ACCT { get; set; }

        public int? MPAY_BL_INSURANCE_COGS_ACCT { get; set; }

        public int? MPAY_BL_INSURANCE_AP_ACCT { get; set; }

        public int? SPAY_PAYDAY_DEBIT_CARDS_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? SPAY_PAYDAY_CHECKS_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? SPAY_TITLE_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? SPAY_TITLE_2ND_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? SPAY_SIG_CAB_LENDER_INTEREST_ACCT { get; set; }

        public int? MPAY_BL_DUE_DATE_PAYMENT_QUEUE_SUSPENSE_ACCT { get; set; }

        public int? MPAY_BL_INSURANCE_TAX_ACCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
    }
}
