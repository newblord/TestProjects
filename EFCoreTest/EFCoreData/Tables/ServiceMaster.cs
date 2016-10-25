using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ServiceMaster
    {
        public ServiceMaster()
        {
            ServiceDetail = new HashSet<ServiceDetail>();
            ServiceSubItemServiceMasterKeyRequisiteNavigation = new HashSet<ServiceSubItem>();
            ServiceSubItemServiceMasterKeySubitemNavigation = new HashSet<ServiceSubItem>();
        }

        public int ServiceMasterKey { get; set; }
        public byte ServiceNum { get; set; }
        public string ServiceName { get; set; }
        public byte DisplayOrder { get; set; }
        public bool Inventoried { get; set; }
        public string FunctionAs { get; set; }
        public bool RequireCust { get; set; }
        public bool Payout { get; set; }
        public bool QtyPrompt { get; set; }
        public bool AmtPrompt { get; set; }
        public bool FeePrompt { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool CashOnly { get; set; }
        public bool IsTracked { get; set; }
        public bool IsPrepaid { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsAutoInventory { get; set; }
        public bool IsSubitem { get; set; }
        public bool IsIndependent { get; set; }
        public bool ReqCustPhone { get; set; }
        public bool ReqCustId { get; set; }

        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }
        public virtual ICollection<ServiceSubItem> ServiceSubItemServiceMasterKeyRequisiteNavigation { get; set; }
        public virtual ICollection<ServiceSubItem> ServiceSubItemServiceMasterKeySubitemNavigation { get; set; }
    }
}
