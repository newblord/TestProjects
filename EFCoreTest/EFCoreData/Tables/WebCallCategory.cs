using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCategory
    {
        public WebCallCategory()
        {
            WebCallCampaignCategory = new HashSet<WebCallCampaignCategory>();
            WebCallRarrcategoryReason = new HashSet<WebCallRarrcategoryReason>();
            WebCallWorkItemCategoryHistory = new HashSet<WebCallWorkItemCategoryHistory>();
        }

        public int WebCallCategoryKey { get; set; }
        public string Category { get; set; }
        public short SortPriority { get; set; }
        public bool Deleted { get; set; }
        public bool? DialerUpload { get; set; }
        public int? DialerRefreshMinutes { get; set; }
        public int? ColorRgb { get; set; }
        public bool IsCujo { get; set; }
        public bool? IsCollections { get; set; }
        public bool? ResetDaily { get; set; }
        public DateTime? LastResetDate { get; set; }

        public virtual ICollection<WebCallCampaignCategory> WebCallCampaignCategory { get; set; }
        public virtual ICollection<WebCallRarrcategoryReason> WebCallRarrcategoryReason { get; set; }
        public virtual ICollection<WebCallWorkItemCategoryHistory> WebCallWorkItemCategoryHistory { get; set; }
    }
}
