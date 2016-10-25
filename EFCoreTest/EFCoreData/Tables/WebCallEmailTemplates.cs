using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallEmailTemplates
    {
        public int WebCallEmailTemplateKey { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public DateTime DateEntered { get; set; }
        public bool IsActive { get; set; }
    }
}
