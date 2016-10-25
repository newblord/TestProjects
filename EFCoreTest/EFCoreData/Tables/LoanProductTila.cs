using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductTila
    {
        public LoanProductTila()
        {
            LoanApplicationProduct = new HashSet<LoanApplicationProduct>();
            LoanProductEnableNewLoan = new HashSet<LoanProductEnableNewLoan>();
        }

        public int LoanProductTilaKey { get; set; }
        public string TilaAddrStreet { get; set; }
        public string TilaAddress1 { get; set; }
        public string TilaBuildingName { get; set; }
        public string TilaBuildingNum { get; set; }
        public string TilaCertNum { get; set; }
        public string TilaCity { get; set; }
        public string TilaCountry { get; set; }
        public string TilaCounty { get; set; }
        public string TilaFlatNum { get; set; }
        public string TilaName { get; set; }
        public string TilaPhone { get; set; }
        public string TilaState { get; set; }
        public string TilaZipcode { get; set; }
        public string AddressFormat { get; set; }
        public string TilaAddressCsz { get; set; }
        public string TilaAddressLine { get; set; }
        public string TilaAddressLine1 { get; set; }
        public string TilaAddressLine2 { get; set; }
        public string TilaAddressLine3 { get; set; }
        public short Location { get; set; }
        public int LoansCount { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoan { get; set; }
    }
}
