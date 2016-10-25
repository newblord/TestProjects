using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SgRights
    {
        public int SgRightsKey { get; set; }
        public string RightName { get; set; }
        public int? ParentRightsKey { get; set; }
        public string ParentRightName { get; set; }
        public string RightType { get; set; }
        public int ValuePosition { get; set; }
        public string GlobalRightName { get; set; }
    }
}
