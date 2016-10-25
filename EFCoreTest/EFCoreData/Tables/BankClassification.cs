using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BankClassification
    {
        public int BankClassificationKey { get; set; }
        public string Bankaba { get; set; }
        public int BankClassificationTypeKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual BankClassificationType BankClassificationTypeKeyNavigation { get; set; }
        public virtual Banks BankabaNavigation { get; set; }
    }
}
