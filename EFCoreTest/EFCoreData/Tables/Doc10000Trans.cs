using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Doc10000Trans
    {
        public Doc10000Trans()
        {
            Doc10000TransDetail = new HashSet<Doc10000TransDetail>();
        }

        public int Doc10000TransKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal CashIn { get; set; }
        public decimal CashOut { get; set; }
        public bool CashedCheck { get; set; }
        public byte FormType { get; set; }

        public virtual ICollection<Doc10000TransDetail> Doc10000TransDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
