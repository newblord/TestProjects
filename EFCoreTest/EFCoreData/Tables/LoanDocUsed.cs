using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDocUsed
    {
        public int LoanDocUsedKey { get; set; }
        public short Location { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public bool UseVehState { get; set; }
        public int? LoanDocKey { get; set; }
        public byte? LoanDocTypeKey { get; set; }
        public byte PrintCopies { get; set; }
        public bool PrintOnNew { get; set; }
        public bool PrintOnRollNew { get; set; }
        public bool PrintOnPayoff { get; set; }
        public bool PrintOnClose { get; set; }
        public bool PrintOnWaPplan { get; set; }
        public byte PrintOrder { get; set; }
        public bool PrintOnRollPaid { get; set; }
        public byte PrintForLien { get; set; }
        public string PrintForDepositMethod { get; set; }
        public short DaysBetweenPrintingPerCustomer { get; set; }
        public bool ScanRequired { get; set; }
        public bool PrintOnDenialSrc { get; set; }
        public bool PrintOnDenialState { get; set; }
        public bool ClearTitlePresent { get; set; }
        public bool ClearTitleMissing { get; set; }
        public bool PrintForEmailStatements { get; set; }
        public bool PrintForNotEmailStatements { get; set; }
        public bool PrintForGiftCards { get; set; }
        public bool PrintForNotGiftCards { get; set; }
        public decimal PrintOnlyLoanAmtMin { get; set; }
        public short NoSignatureAction { get; set; }
        public bool EsignAllowSendToPrinter { get; set; }
        public bool PrintForTitleCoPledger { get; set; }
        public bool PrintForTitleDualOwner { get; set; }
        public int? LoanProductKey { get; set; }

        public virtual LoanDoc LoanDocKeyNavigation { get; set; }
        public virtual LoanDocType LoanDocTypeKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
