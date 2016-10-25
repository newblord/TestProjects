using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExternalAppMaster
    {
        public int ExternalAppMasterKey { get; set; }
        public string TaskName { get; set; }
        public string ServerName { get; set; }
        public string DtsOrExe { get; set; }
        public string RunFile { get; set; }
        public string RunStartFolder { get; set; }
        public string Description { get; set; }
        public string StatusDesc { get; set; }
        public DateTime? NextRunDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastResult { get; set; }
    }
}
