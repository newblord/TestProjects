using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerLogin
    {
        public int TellerLoginKey { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string Hostname { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public bool LoggedIn { get; set; }
        public string ServerName { get; set; }
    }
}
