using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDocType
    {
        public LoanDocType()
        {
            LoanDoc = new HashSet<LoanDoc>();
            LoanDocUsed = new HashSet<LoanDocUsed>();
        }

        public byte LoanDocTypeKey { get; set; }
        public string LoanDocTypeName { get; set; }
        public string LoanDocTypeId { get; set; }
        public string LoanDocTypeNickname { get; set; }

        public virtual ICollection<LoanDoc> LoanDoc { get; set; }
        public virtual ICollection<LoanDocUsed> LoanDocUsed { get; set; }
    }
}
