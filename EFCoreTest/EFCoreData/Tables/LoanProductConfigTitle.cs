using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigTitle
    {
        public int LoanProductConfigTitleKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public int LoanProductKey { get; set; }
        public decimal ApprovalPctEmployed24PlusMonths { get; set; }
        public decimal ApprovalPctEmployed6To23Months { get; set; }
        public decimal ApprovalPctEmployedUpTo5Months { get; set; }
        public decimal ApprovalPctWholesaleGreaterThan1500CheckingAcct { get; set; }
        public decimal ApprovalPctWholesaleGreaterThan1500CheckingAcctDirectDeposit { get; set; }
        public decimal ApprovalPctWholesaleGreaterThan1500DebitCard { get; set; }
        public decimal ApprovalPctWholesaleUpTo1500CheckingAcct { get; set; }
        public decimal ApprovalPctWholesaleUpTo1500CheckingAcctDirectDeposit { get; set; }
        public decimal ApprovalPctWholesaleUpTo1500DebitCard { get; set; }
        public short LegalMaxLoanVehicleValuePct { get; set; }
        public string LegalMaxLoanVehicleValueWholesaleOrRetail { get; set; }
        public decimal LienFeeAmt { get; set; }
        public bool LienFeeFinancedEnabled { get; set; }
        public int LoanAmtMgrOverrideVehicleValuePct { get; set; }
        public string LoanAmtMgrOverrideVehicleWholesaleOrRetail { get; set; }
        public decimal LoanAmtNoInsuranceMaxAmt { get; set; }
        public bool MaxLoanVehicleValuePctEnabled { get; set; }
        public bool MultLoansVinEnabled { get; set; }
        public decimal OrigFeePct2ndLien { get; set; }
        public decimal RepoAssignmentMinBalance { get; set; }
        public bool RequireCopledgeDetails { get; set; }
        public bool RequireCopledgeEyeColor { get; set; }
        public bool RequireCopledgeGender { get; set; }
        public bool RequireCopledgeHairColor { get; set; }
        public bool RequireCopledgeHeight { get; set; }
        public bool RequireCopledgeRace { get; set; }
        public bool RequireCopledgeSsn { get; set; }
        public bool RequireDetails { get; set; }
        public bool RequireEyeColor { get; set; }
        public bool RequireGender { get; set; }
        public bool RequireHairColor { get; set; }
        public bool RequireHeight { get; set; }
        public bool RequireRace { get; set; }
        public bool UseFuelType { get; set; }
        public bool UseLegalStatus { get; set; }
        public bool UseLienHolder { get; set; }
        public bool UseOdoCode { get; set; }
        public bool UseRegistrationDate { get; set; }
        public bool UseRegistrationExpires { get; set; }
        public bool UseStateNum { get; set; }
        public bool UseStickerNum { get; set; }
        public bool UseTitleNum { get; set; }
        public decimal VehValueMinAmt { get; set; }
        public byte MaxLoanVehicleValuePct { get; set; }
        public string MaxLoanVehicleValuePctWholesaleOrRetail { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
