using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ServiceTrans
    {
        public ServiceTrans()
        {
            CourtesyPayout = new HashSet<CourtesyPayout>();
            ServiceTransDetail = new HashSet<ServiceTransDetail>();
        }

        public int ServiceTransKey { get; set; }
        public int ServiceDetailKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? MoStatusKey { get; set; }
        public short Location { get; set; }
        public short QtySold { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal ServiceAmt { get; set; }
        public int? GlAcctFee { get; set; }
        public int? GlAcctAmt { get; set; }
        public byte PaymentMethod { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public decimal? CalcExtend { get; set; }

        public virtual ICollection<CourtesyPayout> CourtesyPayout { get; set; }
        public virtual ICollection<ServiceTransDetail> ServiceTransDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Glacct GlAcctAmtNavigation { get; set; }
        public virtual Glacct GlAcctFeeNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
