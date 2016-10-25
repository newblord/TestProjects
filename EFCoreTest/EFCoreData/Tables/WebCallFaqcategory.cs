using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallFaqcategory
    {
        public WebCallFaqcategory()
        {
            WebCallFaq = new HashSet<WebCallFaq>();
        }

        public int WebCallFaqCategoryKey { get; set; }
        public string FaqCategoryDescription { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<WebCallFaq> WebCallFaq { get; set; }
    }
}
