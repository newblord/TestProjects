using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProcessConfigInstance
    {
        public ProcessConfigInstance()
        {
            ProcessConfigDetail = new HashSet<ProcessConfigDetail>();
            ProcessConfigDetailHistory = new HashSet<ProcessConfigDetailHistory>();
            ProcessConfigInstanceGroup = new HashSet<ProcessConfigInstanceGroup>();
            ProcessConfigInstanceTeller = new HashSet<ProcessConfigInstanceTeller>();
            ProcessSchedule = new HashSet<ProcessSchedule>();
        }

        public int ProcessConfigInstanceKey { get; set; }
        public int ProcessConfigKey { get; set; }
        public string InstanceName { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsActive { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? LastusedDate { get; set; }

        public virtual ICollection<ProcessConfigDetail> ProcessConfigDetail { get; set; }
        public virtual ICollection<ProcessConfigDetailHistory> ProcessConfigDetailHistory { get; set; }
        public virtual ICollection<ProcessConfigInstanceGroup> ProcessConfigInstanceGroup { get; set; }
        public virtual ICollection<ProcessConfigInstanceTeller> ProcessConfigInstanceTeller { get; set; }
        public virtual ICollection<ProcessSchedule> ProcessSchedule { get; set; }
        public virtual ProcessConfig ProcessConfigKeyNavigation { get; set; }
    }
}
