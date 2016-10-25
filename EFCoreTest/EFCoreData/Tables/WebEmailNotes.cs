using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebEmailNotes
    {
        public int WebEmailNotesKey { get; set; }
        public string WebEmailUniqueId { get; set; }
        public string Teller { get; set; }
        public string Notes { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
