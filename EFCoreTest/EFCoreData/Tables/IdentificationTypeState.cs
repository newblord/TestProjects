using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IdentificationTypeState
    {
        public int IdentificationTypeStateKey { get; set; }
        public int IdentificationTypeKey { get; set; }
        public string IdState { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public bool StoreExpirationRequired { get; set; }
        public bool StoreAcceptableForNewLoan { get; set; }
        public bool WebAcceptableForNewLoan { get; set; }
        public bool WebExpirationRequired { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
