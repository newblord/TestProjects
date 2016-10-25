using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Smstemplate
    {
        public int SmsTemplateKey { get; set; }
        public int Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Template { get; set; }
        public bool IsActive { get; set; }
        public bool IsSystem { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
