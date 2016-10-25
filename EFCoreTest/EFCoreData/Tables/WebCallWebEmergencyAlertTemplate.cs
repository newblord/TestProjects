using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallWebEmergencyAlertTemplate
    {
        public int WebCallWebEmergencyAlertTemplateKey { get; set; }
        public string Scenario { get; set; }
        public string AlertTemplateText { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
