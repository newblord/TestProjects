using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProduct
    {
        public LoanProduct()
        {
            DiscountMasterLoanProduct = new HashSet<DiscountMasterLoanProduct>();
            FurtherFinanceExecutionLogDetail = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetail = new HashSet<FurtherFinanceResultDetail>();
            LoanApplicationProduct = new HashSet<LoanApplicationProduct>();
            LoanDocUsed = new HashSet<LoanDocUsed>();
            LoanProductConfig = new HashSet<LoanProductConfig>();
            LoanProductConfigOpenEnd = new HashSet<LoanProductConfigOpenEnd>();
            LoanProductConfigTitle = new HashSet<LoanProductConfigTitle>();
            LoanProductFeature = new HashSet<LoanProductFeature>();
            LoanProductRollover = new HashSet<LoanProductRollover>();
            ProductOpenLoanMatrixLoanProductKeyAllowedNavigation = new HashSet<ProductOpenLoanMatrix>();
            ProductOpenLoanMatrixLoanProductKeyOpenNavigation = new HashSet<ProductOpenLoanMatrix>();
            SpecialMessageLoanProduct = new HashSet<SpecialMessageLoanProduct>();
            TempLoanProductSplitNewLoanProductKeyNavigation = new HashSet<TempLoanProductSplit>();
            TempLoanProductSplitOrigLoanProductKeyNavigation = new HashSet<TempLoanProductSplit>();
            WebCallLoanProductConfig = new HashSet<WebCallLoanProductConfig>();
        }

        public int LoanProductKey { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool IsExpress { get; set; }
        public bool IsBusiness { get; set; }
        public bool IsEasypay { get; set; }
        public string BusinessState { get; set; }
        public string Note { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<DiscountMasterLoanProduct> DiscountMasterLoanProduct { get; set; }
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetail { get; set; }
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetail { get; set; }
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        public virtual ICollection<LoanDocUsed> LoanDocUsed { get; set; }
        public virtual ICollection<LoanProductConfig> LoanProductConfig { get; set; }
        public virtual ICollection<LoanProductConfigOpenEnd> LoanProductConfigOpenEnd { get; set; }
        public virtual ICollection<LoanProductConfigTitle> LoanProductConfigTitle { get; set; }
        public virtual ICollection<LoanProductFeature> LoanProductFeature { get; set; }
        public virtual ICollection<LoanProductRollover> LoanProductRollover { get; set; }
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrixLoanProductKeyAllowedNavigation { get; set; }
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrixLoanProductKeyOpenNavigation { get; set; }
        public virtual ICollection<SpecialMessageLoanProduct> SpecialMessageLoanProduct { get; set; }
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplitNewLoanProductKeyNavigation { get; set; }
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplitOrigLoanProductKeyNavigation { get; set; }
        public virtual ICollection<WebCallLoanProductConfig> WebCallLoanProductConfig { get; set; }
    }
}
