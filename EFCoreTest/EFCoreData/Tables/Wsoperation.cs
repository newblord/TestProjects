using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Wsoperation
    {
        public Wsoperation()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTrans>();
        }

        public int WsOperationKey { get; set; }
        public int WsConfigKey { get; set; }
        public string OperationName { get; set; }
        public string OperationDescription { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? PrepaidCardTransActionKey { get; set; }

        public virtual ICollection<PrepaidCardTrans> PrepaidCardTrans { get; set; }
        public virtual PrepaidCardTransAction PrepaidCardTransActionKeyNavigation { get; set; }
        public virtual Wsconfig WsConfigKeyNavigation { get; set; }
    }
}
