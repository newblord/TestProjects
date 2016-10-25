using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerIdentification
    {
        public CustomerIdentification()
        {
            CustomerIdentificationEdit = new HashSet<CustomerIdentificationEdit>();
        }

        public int CustomerIdentificationKey { get; set; }
        public int CustomerKey { get; set; }
        public int IdentificationTypeKey { get; set; }
        public string IdNumber { get; set; }
        public string IdSource { get; set; }
        public string CustIdCountry { get; set; }
        public string CustIdState { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string VerifiedOther { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? IdentificationTypeVerifyKey { get; set; }

        public virtual ICollection<CustomerIdentificationEdit> CustomerIdentificationEdit { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual IdentificationType IdentificationTypeKeyNavigation { get; set; }
        public virtual IdentificationTypeVerify IdentificationTypeVerifyKeyNavigation { get; set; }
    }
}
