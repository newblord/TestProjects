using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallRarr
    {
        public WebCallRarr()
        {
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallRarrfeatures = new HashSet<WebCallRarrfeatures>();
        }

        public int WebCallRarrKey { get; set; }
        public int WebCallRarrReasonKey { get; set; }
        public int WebCallRarrActionKey { get; set; }
        public int WebCallRarrResult1Key { get; set; }
        public int WebCallRarrResult2Key { get; set; }
        public bool FollowUpEnabled { get; set; }
        public int FollowUpAutoPopulate { get; set; }
        public bool FollowUpPopUpSettingDialog { get; set; }
        public bool Deleted { get; set; }
        public bool? EscalateToSupervisor { get; set; }
        public int? IatresultTypeKey { get; set; }
        public bool? Disabled { get; set; }
        public int? WebCallRarrGroupKey { get; set; }
        public bool? UpdateCategory { get; set; }
        public int? NewCategoryId { get; set; }
        public int Points { get; set; }
        public bool SupervisorOnlyRarr { get; set; }
        public int? WebDialerResultTypeKey { get; set; }
        public int? WebCallRarrTypeKey { get; set; }

        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallRarrfeatures> WebCallRarrfeatures { get; set; }
        public virtual WebDialerResultType WebDialerResultTypeKeyNavigation { get; set; }
    }
}
