using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfig
    {
        public ProcessConfig()
        {
            ProcessConfigInstance = new HashSet<ProcessConfigInstance>();
        }

        public int ProcessConfigKey { get; set; }
        public string ProcessName { get; set; }
        public string ProcessCommand { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<ProcessConfigInstance> ProcessConfigInstance { get; set; }
    }
}
