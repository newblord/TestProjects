using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Wsconfig
    {
        public Wsconfig()
        {
            Wsoperation = new HashSet<Wsoperation>();
            Wsresponse = new HashSet<Wsresponse>();
        }

        public int WsConfigKey { get; set; }
        public string ProviderName { get; set; }
        public string ProviderDescription { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string ProviderVersion { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Wsoperation> Wsoperation { get; set; }
        public virtual ICollection<Wsresponse> Wsresponse { get; set; }
    }
}
