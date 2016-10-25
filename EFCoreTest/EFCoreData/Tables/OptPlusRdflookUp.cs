using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdflookUp
    {
        public string RdfCode { get; set; }
        public string FieldName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string RdfFile { get; set; }
        public int LookupKey { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
