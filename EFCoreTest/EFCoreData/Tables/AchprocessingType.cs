using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchprocessingType
    {
        public AchprocessingType()
        {
            AchprocessingQueue = new HashSet<AchprocessingQueue>();
        }

        public int AchProcessingTypeKey { get; set; }
        public string AchProcessingTypeDesc { get; set; }
        public string FileType { get; set; }

        public virtual ICollection<AchprocessingQueue> AchprocessingQueue { get; set; }
    }
}
