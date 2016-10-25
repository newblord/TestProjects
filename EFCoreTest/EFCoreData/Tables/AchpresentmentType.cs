using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchpresentmentType
    {
        public AchpresentmentType()
        {
            Achpresentment = new HashSet<Achpresentment>();
        }

        public int AchPresentmentTypeKey { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Achpresentment> Achpresentment { get; set; }
    }
}
