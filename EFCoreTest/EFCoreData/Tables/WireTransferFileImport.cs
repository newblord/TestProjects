using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WireTransferFileImport
    {
        public int WireTransferFileImportKey { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportProcess { get; set; }
        public string WireTransferFileName { get; set; }
        public int? RunMasterKey { get; set; }
    }
}
