using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardTrans
    {
        public int PrepaidCardTransKey { get; set; }
        public int? TransDetailKey { get; set; }
        public int WsOperationKey { get; set; }
        public int WsResponseKey { get; set; }
        public string OperationParms { get; set; }
        public string OperationResults { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? CustomerKey { get; set; }
        public int? CreditCardKey { get; set; }
        public string ComputerName { get; set; }
        public string ServerName { get; set; }
        public decimal? Amount { get; set; }
        public int? PrepaidCardTransActionKey { get; set; }
        public short? Location { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual PrepaidCardTransAction PrepaidCardTransActionKeyNavigation { get; set; }
        public virtual Wsoperation WsOperationKeyNavigation { get; set; }
        public virtual Wsresponse WsResponseKeyNavigation { get; set; }
    }
}
