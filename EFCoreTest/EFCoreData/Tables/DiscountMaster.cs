using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountMaster
    {
        public DiscountMaster()
        {
            DiscountLocations = new HashSet<DiscountLocations>();
            DiscountMasterLoanProduct = new HashSet<DiscountMasterLoanProduct>();
            DiscountSecurity = new HashSet<DiscountSecurity>();
            DiscountUsed = new HashSet<DiscountUsed>();
        }

        public int DiscountMasterKey { get; set; }
        public int? DiscountTypeKey { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountName { get; set; }
        public string Description { get; set; }
        public int? GlAcct { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte AmountType { get; set; }
        public decimal DefaultAmt { get; set; }
        public decimal MaxAmt { get; set; }
        public bool ApplyToChecks { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public bool IsActive { get; set; }
        public bool RouteRequired { get; set; }
        public byte CustomerLevel { get; set; }
        public int? EarnedCreditTypeKey { get; set; }
        public string ApplyDiscountTo { get; set; }
        public bool IsAutoApplied { get; set; }

        public virtual ICollection<DiscountLocations> DiscountLocations { get; set; }
        public virtual ICollection<DiscountMasterLoanProduct> DiscountMasterLoanProduct { get; set; }
        public virtual ICollection<DiscountSecurity> DiscountSecurity { get; set; }
        public virtual ICollection<DiscountUsed> DiscountUsed { get; set; }
        public virtual DiscountType DiscountTypeKeyNavigation { get; set; }
        public virtual EarnedCreditType EarnedCreditTypeKeyNavigation { get; set; }
        public virtual Glacct GlAcctNavigation { get; set; }
    }
}
