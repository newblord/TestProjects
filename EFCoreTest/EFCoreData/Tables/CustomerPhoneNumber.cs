using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerPhoneNumber
    {
        public CustomerPhoneNumber()
        {
            CustomerEmployer = new HashSet<CustomerEmployer>();
            CustomerPhoneNumberEdit = new HashSet<CustomerPhoneNumberEdit>();
        }

        public int CustomerPhoneNumberKey { get; set; }
        public int CustomerKey { get; set; }
        public byte PhoneTypeCode { get; set; }
        public byte PhoneSourceCode { get; set; }
        public byte PhoneStatusCode { get; set; }
        public short PhonePriority { get; set; }
        public string PhoneContactLastName { get; set; }
        public string PhoneContactFirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateLastUsed { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public string StatusChangeTeller { get; set; }
        public DateTime? PriorityChangeDate { get; set; }
        public string PriorityChangeTeller { get; set; }
        public byte TimesUsed { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool? CallCenterDoNotCall { get; set; }
        public DateTime? CallCenterDoNotCallUntil { get; set; }
        public DateTime? CallCenterDoNotCallChangeDate { get; set; }
        public string CallCenterDoNotCallChangeTeller { get; set; }
        public DateTime? AutoDialConsentModificationDate { get; set; }
        public DateTime? PhysicalCellNumberLastCheckedDate { get; set; }
        public bool? HasAutoDialConsent { get; set; }
        public bool? IsPhysicalCellNumber { get; set; }

        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<CustomerPhoneNumberEdit> CustomerPhoneNumberEdit { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
