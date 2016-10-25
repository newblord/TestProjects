using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IdentificationTypeAml
    {
        public IdentificationTypeAml()
        {
            IdentificationType = new HashSet<IdentificationType>();
        }

        public byte IdentificationTypeAmlKey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<IdentificationType> IdentificationType { get; set; }
    }
}
