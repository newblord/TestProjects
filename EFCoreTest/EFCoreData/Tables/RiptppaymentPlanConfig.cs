using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiptppaymentPlanConfig
    {
        public RiptppaymentPlanConfig()
        {
            PromiseToPay = new HashSet<PromiseToPay>();
        }

        public int PtpConfigKey { get; set; }
        public string PtpPlanName { get; set; }
        public string PtpPlTypes { get; set; }
        public string PtpLocations { get; set; }
        public string PtpPaymentMethods { get; set; }
        public byte PtpMaxNumberPayments { get; set; }
        public short PtpMaxNumberPlanDays { get; set; }
        public byte PtpDefaultPaymentNumber { get; set; }
        public short PtpFirstPaymentPercent { get; set; }
        public short PtpMaxDaysExtDays { get; set; }
        public short PtpDefDaysBetweenPmts { get; set; }
        public short PtpGraceDays { get; set; }
        public bool PtpAllowWaiveFee { get; set; }
        public bool PtpModApprovalReq { get; set; }
        public bool PtpDmCrmApprovalReq { get; set; }
        public short? PtpAuditCategory { get; set; }
        public string Security { get; set; }
        public bool ExtendedPaymentPlan { get; set; }
        public bool StateSpecificPaymentPlan { get; set; }
        public bool IsInternet { get; set; }
        public decimal BrokenPtpFee { get; set; }
        public bool IsLoanMatured { get; set; }
        public bool IsLoanInactive { get; set; }
        public bool IsLoanNotMatured { get; set; }
        public bool IsLoanNotInactive { get; set; }
        public byte PtpMinNumberPayments { get; set; }
        public bool RequireSignature { get; set; }

        public virtual ICollection<PromiseToPay> PromiseToPay { get; set; }
    }
}
