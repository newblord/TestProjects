using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCenterLogin
    {
        public int CallCenterLoginKey { get; set; }
        public string Teller { get; set; }
        public string Server { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public bool LoggedIn { get; set; }
    }
}
