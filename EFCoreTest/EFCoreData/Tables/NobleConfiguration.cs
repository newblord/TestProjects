using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class NobleConfiguration
    {
        public int NobleConfigKey { get; set; }
        public string CollectionsExclusionTableName { get; set; }
        public string CollectionsTableName { get; set; }
        public string CourtesyTableName { get; set; }
        public string InternetLendingTableName { get; set; }
        public int? InternetLendingListId { get; set; }
        public string TableNamePrefix { get; set; }
        public byte TimeOffsetFromNoble { get; set; }
        public string TellerId { get; set; }
    }
}
