using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocumentPrinting
    {
        public int DocumentPrintingKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public string ComputerName { get; set; }
        public string PrinterName { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
