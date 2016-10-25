using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallTeamUsers
    {
        public int WebCallTeamUserKey { get; set; }
        public int WebCallTeamKey { get; set; }
        public string Teller { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual WebCallTeams WebCallTeamKeyNavigation { get; set; }
    }
}
