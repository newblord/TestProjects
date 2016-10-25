using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidFisauthTrans
    {
        public int AuthTransKey { get; set; }
        public int? CustomerKey { get; set; }
        public short? ProcessStatus { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? IssuerClientId { get; set; }
        public string IssuerClientName { get; set; }
        public int? SubprogramId { get; set; }
        public string SubprogramName { get; set; }
        public int? BinNum { get; set; }
        public string BinCurrAlpha { get; set; }
        public string BinCurrCode { get; set; }
        public string BankName { get; set; }
        public string PrimeAcctNum { get; set; }
        public string CardAcctNum { get; set; }
        public string TxnUid { get; set; }
        public int? TxnTypeCode { get; set; }
        public string TxnTypeName { get; set; }
        public int? PurseNum { get; set; }
        public string PurseName { get; set; }
        public DateTime? TransDatetime { get; set; }
        public string AuthorizeCode { get; set; }
        public int? RequestCode { get; set; }
        public string RequestDesc { get; set; }
        public int? ResponseCode { get; set; }
        public string ResponseDesc { get; set; }
        public int? ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
        public int? SourceCode { get; set; }
        public string SourceDesc { get; set; }
        public decimal? AuthorizeAmt { get; set; }
        public decimal? TxnLocalAmt { get; set; }
        public short? TransSign { get; set; }
        public int? TransCurrCode { get; set; }
        public string TransCurrAlpha { get; set; }
        public string RetrievalRefno { get; set; }
        public short? Reversed { get; set; }
        public string AvsInfo { get; set; }
        public string AvsRespCode { get; set; }
        public short? Pin { get; set; }
        public string PosData { get; set; }
        public int? PosEntryCode { get; set; }
        public string PosEntryDesc { get; set; }
        public string MercMccCode { get; set; }
        public string MccDescription { get; set; }
        public string MercCurrAlpha { get; set; }
        public string MercCurrCode { get; set; }
        public string MercName { get; set; }
        public string MercNum { get; set; }
        public string MercStreet { get; set; }
        public string MercCity { get; set; }
        public string MercProv { get; set; }
        public string MercState { get; set; }
        public string MercZip { get; set; }
        public string MercCtryCode { get; set; }
        public string MercCtryName { get; set; }
        public string TermNum { get; set; }
        public string AcqId { get; set; }
        public string CanProxyNum { get; set; }
        public string ClientUniqueId { get; set; }
        public decimal? AuthBal { get; set; }
        public decimal? SettleBal { get; set; }
        public decimal? ToleranceAmt { get; set; }
        public string CardVerifyMethod { get; set; }
        public string CvcResponse { get; set; }
        public string PanProxyNum { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
