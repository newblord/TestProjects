using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdfcustomerMaster
    {
        public string ProgramId { get; set; }
        public string IssueDate { get; set; }
        public string PrimaryId { get; set; }
        public string PrimaryIdtype { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Status { get; set; }
        public decimal? CurrBalAmt { get; set; }
        public string CurrBalSign { get; set; }
        public string DateEntered { get; set; }
        public string NegBalDate { get; set; }
        public decimal? NegBalFeeAmt { get; set; }
        public bool? IsReloadable { get; set; }
        public string AccountId { get; set; }
        public string AccountType { get; set; }
        public decimal? AvailBalAmt { get; set; }
        public string AvailBalSign { get; set; }
        public string ExtAcctNum { get; set; }
        public string LastTransDate { get; set; }
        public string Dob { get; set; }
        public short? BillCycleDay { get; set; }
        public string LocationId { get; set; }
        public string AgentuserId { get; set; }
        public string SecondaryId { get; set; }
        public string SecondaryIdtype { get; set; }
        public string UserData1 { get; set; }
        public string UserData2 { get; set; }
        public int? CustomerKey { get; set; }
        public int CustomerMasterKey { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
