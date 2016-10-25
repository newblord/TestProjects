using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerResultType
    {
        public WebDialerResultType()
        {
            WebCallRarr = new HashSet<WebCallRarr>();
            WebDialerResult = new HashSet<WebDialerResult>();
        }

        public int IatresultTypeKey { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public string FiveNineKey { get; set; }
        public int? WebCallCatrarrAliasKey { get; set; }
        public bool? IsSystemDisposition { get; set; }
        public int WebDialerResultTypeKey { get; set; }

        public virtual ICollection<WebCallRarr> WebCallRarr { get; set; }
        public virtual ICollection<WebDialerResult> WebDialerResult { get; set; }
    }
}
