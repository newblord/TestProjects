using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidFiscustomerMaster
    {
        public int CustomerMasterKey { get; set; }
        public int? CustomerKey { get; set; }
        public short? ProcessStatus { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? TopClientId { get; set; }
        public string TopClientName { get; set; }
        public int? IssuerClientId { get; set; }
        public string ClientName { get; set; }
        public int? ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int? SubprogramId { get; set; }
        public string SubprogramName { get; set; }
        public int? BinNum { get; set; }
        public string BinCurrAlpha { get; set; }
        public string BinCurrCode { get; set; }
        public int? PackageId { get; set; }
        public string PackageName { get; set; }
        public string PrimeAcctNum { get; set; }
        public string CardAcctNum { get; set; }
        public DateTime? ActivateDate { get; set; }
        public int? CardStatus { get; set; }
        public string CardholderFirstname { get; set; }
        public string CardholderLastname { get; set; }
        public string CardholderMiddlename { get; set; }
        public string MailAddrLine1 { get; set; }
        public string MailAddrLine2 { get; set; }
        public string MailCity { get; set; }
        public string MailState { get; set; }
        public string MailZip { get; set; }
        public string MailCtry { get; set; }
        public int? CardholderCtryCode { get; set; }
        public string CardholderPhone { get; set; }
        public string CardholderPhoneExt { get; set; }
        public DateTime? CanCreateDate { get; set; }
        public DateTime? CanExpireDate { get; set; }
        public int? MarketSegId { get; set; }
        public string MarketSegDesc { get; set; }
        public int? RequestCode { get; set; }
        public int? SourceCode { get; set; }
        public DateTime? WcsutcInserted { get; set; }
        public DateTime? CanStatusEffectiveDate { get; set; }
        public DateTime? CardholderDob { get; set; }
        public string CardholderEmail { get; set; }
        public string CardholderSsn { get; set; }
        public string CardholderSuffix { get; set; }
        public string CardStatusDesc { get; set; }
        public string ClientMemo { get; set; }
        public DateTime? AccountCreateDate { get; set; }
        public string CanProxyNum { get; set; }
        public string PrivacyOptOut { get; set; }
        public string PrimaryRelationship { get; set; }
        public string RequestCodeDesc { get; set; }
        public string SourceCodeDesc { get; set; }
        public int? PersonId { get; set; }
        public string ClientUniqueId { get; set; }
        public string AlertsEmail { get; set; }
        public string DirectAccessNumber { get; set; }
        public string SmsMobilePhone { get; set; }
        public string PanProxyNum { get; set; }
        public DateTime? InitValueLoad { get; set; }
        public DateTime? PersonCreateDate { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
