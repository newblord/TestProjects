using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdfaccountCard
    {
        public string ProgramId { get; set; }
        public string GroupId { get; set; }
        public string ProductId { get; set; }
        public string AccountId { get; set; }
        public string Prn { get; set; }
        public string ExpDate { get; set; }
        public string Status { get; set; }
        public string CardId { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public int? CustomerKey { get; set; }
        public int AccountCardKey { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
