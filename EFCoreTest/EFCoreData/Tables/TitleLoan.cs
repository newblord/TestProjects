using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TitleLoan
    {
        public TitleLoan()
        {
            RepoCaseHistory = new HashSet<RepoCaseHistory>();
            TitleLoanApproval = new HashSet<TitleLoanApproval>();
        }

        public int TitleloanKey { get; set; }
        public int LoanKey { get; set; }
        public int VehicleKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal VehWholesale { get; set; }
        public int VehMileage { get; set; }
        public string VehCondition { get; set; }
        public string VehPlate { get; set; }
        public string VehSticker { get; set; }
        public DateTime? VehRegDate { get; set; }
        public DateTime? VehRegExpire { get; set; }
        public string VehRegState { get; set; }
        public string VehTitleNum { get; set; }
        public string VehOdoCode { get; set; }
        public string LegalStatus { get; set; }
        public string StateCustNum { get; set; }
        public string InsName { get; set; }
        public string InsPhone { get; set; }
        public bool InsFullCover { get; set; }
        public string InsPolicyNum { get; set; }
        public bool PayVerified { get; set; }
        public string AndOrName { get; set; }
        public int? LienHolderKey { get; set; }
        public decimal? LienBalance { get; set; }
        public string LienAcctNum { get; set; }
        public string VehVin { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public string VehBody { get; set; }
        public string VehEngine { get; set; }
        public string VehTrans { get; set; }
        public string VehDrive { get; set; }
        public string VehMiscEquip1 { get; set; }
        public string VehMiscEquip2 { get; set; }
        public string VehMiscEquip3 { get; set; }
        public short VehYear { get; set; }
        public decimal ListPrice { get; set; }
        public string VehColor { get; set; }
        public string FuelType { get; set; }
        public decimal VehRetail { get; set; }
        public string VehKov { get; set; }
        public bool IsClearTitle { get; set; }
        public bool IsExpress { get; set; }
        public string Gender { get; set; }
        public byte HeightFeet { get; set; }
        public byte HeightInches { get; set; }
        public short Weight { get; set; }
        public byte Race { get; set; }
        public byte EyeColor { get; set; }
        public byte HairColor { get; set; }
        public string VehEngineSize { get; set; }
        public string VehEngineNumber { get; set; }
        public bool VehNoLongerOwnedByCust { get; set; }
        public string LenderName { get; set; }
        public string LenderCertificateId { get; set; }
        public int? AgreementNumber { get; set; }
        public int? LoanCoPledgerKey { get; set; }
        public string AndOrFirstname { get; set; }
        public string AndOrMidname { get; set; }
        public string AndOrLastname { get; set; }
        public string RepoCaseNum { get; set; }
        public string RepoAgentTeller { get; set; }
        public DateTime? RepoDateEntered { get; set; }
        public bool TitleReleased { get; set; }
        public decimal TransFeeInclDocPrepFeeAmt { get; set; }

        public virtual ICollection<RepoCaseHistory> RepoCaseHistory { get; set; }
        public virtual ICollection<TitleLoanApproval> TitleLoanApproval { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual LienHolder LienHolderKeyNavigation { get; set; }
        public virtual LoanCoPledger LoanCoPledgerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Vehicle VehicleKeyNavigation { get; set; }
    }
}
