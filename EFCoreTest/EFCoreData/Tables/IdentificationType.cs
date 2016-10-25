using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IdentificationType
    {
        public IdentificationType()
        {
            CustomerIdentification = new HashSet<CustomerIdentification>();
        }

        public int IdentificationTypeKey { get; set; }
        public string IdTypeDescription { get; set; }
        public byte IdTypeCategory { get; set; }
        public bool IsActive { get; set; }
        public byte MaxAllowedIdType { get; set; }
        public bool GovtIssued { get; set; }
        public bool NumberRequired { get; set; }
        public bool CountryRequired { get; set; }
        public bool StateRequired { get; set; }
        public bool AmlPrimary { get; set; }
        public bool AmlSecondary { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte IdentificationTypeAmlKey { get; set; }
        public bool CtrReporting { get; set; }

        public virtual ICollection<CustomerIdentification> CustomerIdentification { get; set; }
        public virtual IdentificationTypeAml IdentificationTypeAmlKeyNavigation { get; set; }
    }
}
