using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusProduct
    {
        public OptPlusProduct()
        {
            OptPlusBinProduct = new HashSet<OptPlusBinProduct>();
            OptPlusCardDetail = new HashSet<OptPlusCardDetail>();
        }

        public int OptplusProductKey { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public bool IsWebProduct { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsOverdraft { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateTerminated { get; set; }
        public bool IsActiveForChangeProduct { get; set; }

        public virtual ICollection<OptPlusBinProduct> OptPlusBinProduct { get; set; }
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetail { get; set; }
    }
}
