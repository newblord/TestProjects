using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            CustomerAddressEdit = new HashSet<CustomerAddressEdit>();
            CustomerEmployer = new HashSet<CustomerEmployer>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            FormLetterResult = new HashSet<FormLetterResult>();
        }

        public int CustomerAddressKey { get; set; }
        public int CustomerKey { get; set; }
        public byte AddressTypeCode { get; set; }
        public byte AddressSourceCode { get; set; }
        public byte AddressStatusCode { get; set; }
        public short AddressPriority { get; set; }
        public string AddressContactLastName { get; set; }
        public string AddressContactFirstName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateLastUsed { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public string StatusChangeTeller { get; set; }
        public DateTime? PriorityChangeDate { get; set; }
        public string PriorityChangeTeller { get; set; }
        public string AddrNum { get; set; }
        public string AddrPreDir { get; set; }
        public string AddrStreet { get; set; }
        public string AddrSuffix { get; set; }
        public string AddrPostDir { get; set; }
        public string AddrSuite { get; set; }
        public string AddrSuiteNum { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string AddressFormat { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string AddressLine { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public byte? RemovedReasonKey { get; set; }
        public string RemovedReasonNotes { get; set; }

        public virtual ICollection<CustomerAddressEdit> CustomerAddressEdit { get; set; }
        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<FormLetterResult> FormLetterResult { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual RemovedReason RemovedReasonKeyNavigation { get; set; }
    }
}
