using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductEnableNewLoan
    {
        public int LoanProductEnableNewLoanKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public int LoanProductTilaKey { get; set; }
        public short Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool EnableAgreementNumber { get; set; }
        public int NextAgreementNumber { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public short? LienAddressLocation { get; set; }
        public byte? HotkeyNumber { get; set; }
        public byte? DisplayOrder { get; set; }

        public virtual Company LienAddressLocationNavigation { get; set; }
        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProductTila LoanProductTilaKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
