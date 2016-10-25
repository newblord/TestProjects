using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallTeams
    {
        public WebCallTeams()
        {
            WebCallTeamUsers = new HashSet<WebCallTeamUsers>();
        }

        public int WebCallTeamKey { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<WebCallTeamUsers> WebCallTeamUsers { get; set; }
    }
}
