using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardTransAction
    {
        public PrepaidCardTransAction()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTrans>();
            Wsoperation = new HashSet<Wsoperation>();
        }

        public int PrepaidCardTransActionKey { get; set; }
        public string ActionName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateActiveChanged { get; set; }
        public string TellerActiveChanged { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<PrepaidCardTrans> PrepaidCardTrans { get; set; }
        public virtual ICollection<Wsoperation> Wsoperation { get; set; }
    }
}
