using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchReturnCode
    {
        public AchReturnCode()
        {
            AchHistory = new HashSet<AchHistory>();
        }

        public int AchRetcodeKey { get; set; }
        public string AchRetcode { get; set; }
        public string RetcodeShort { get; set; }
        public string RetcodeLong { get; set; }
        public int RisTypeId { get; set; }

        public virtual ICollection<AchHistory> AchHistory { get; set; }
    }
}
