using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldItem
    {
        public GoldItem()
        {
            GoldConfigItem = new HashSet<GoldConfigItem>();
            GoldTransDetail = new HashSet<GoldTransDetail>();
        }

        public short GoldItemKey { get; set; }
        public string ItemDescription { get; set; }
        public string ItemType { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GoldConfigItem> GoldConfigItem { get; set; }
        public virtual ICollection<GoldTransDetail> GoldTransDetail { get; set; }
    }
}
