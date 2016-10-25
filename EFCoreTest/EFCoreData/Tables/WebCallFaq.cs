using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallFaq
    {
        public WebCallFaq()
        {
            WebCallFaqattachment = new HashSet<WebCallFaqattachment>();
        }

        public int WebCallFaqKey { get; set; }
        public int WebCallFaqCategoryKey { get; set; }
        public string FaqTitle { get; set; }
        public string FaqContent { get; set; }

        public virtual ICollection<WebCallFaqattachment> WebCallFaqattachment { get; set; }
        public virtual WebCallFaqcategory WebCallFaqCategoryKeyNavigation { get; set; }
    }
}
