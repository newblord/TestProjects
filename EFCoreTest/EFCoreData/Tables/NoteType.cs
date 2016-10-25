using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class NoteType
    {
        public int NoteTypeKey { get; set; }
        public int NoteTypeValue { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
    }
}
