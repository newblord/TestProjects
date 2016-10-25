using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerX
    {
        public DrawerX()
        {
            DrawerXservice = new HashSet<DrawerXservice>();
        }

        public int DrawerxKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal DrawerxMisc { get; set; }
        public decimal DrawerxCcard { get; set; }

        public virtual ICollection<DrawerXservice> DrawerXservice { get; set; }
    }
}
