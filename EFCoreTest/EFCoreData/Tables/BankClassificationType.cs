using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BankClassificationType
    {
        public BankClassificationType()
        {
            BankClassification = new HashSet<BankClassification>();
        }

        public int BankClassificationTypeKey { get; set; }
        public int BankClassificationType1 { get; set; }
        public string BankClassificationDesc { get; set; }

        public virtual ICollection<BankClassification> BankClassification { get; set; }
    }
}
