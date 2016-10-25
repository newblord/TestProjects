using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallLoggingCategory
    {
        public WebCallLoggingCategory()
        {
            WebCallLoggingCategoryLog = new HashSet<WebCallLoggingCategoryLog>();
        }

        public int WebCallLoggingCategoryKey { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<WebCallLoggingCategoryLog> WebCallLoggingCategoryLog { get; set; }
    }
}
