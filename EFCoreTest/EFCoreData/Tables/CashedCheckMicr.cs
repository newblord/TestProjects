using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheckMicr
    {
        public int CashedCheckMicrKey { get; set; }
        public int CashedCheckKey { get; set; }
        public string Micrdata { get; set; }
        public string AuxOnUs { get; set; }
        public string TransitNumber { get; set; }
        public string ExternalProcessingCode { get; set; }
        public string ChecksumDigit { get; set; }
        public string OnUs { get; set; }
        public string MicrAmount { get; set; }
        public string DepositBankControlData { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
    }
}
