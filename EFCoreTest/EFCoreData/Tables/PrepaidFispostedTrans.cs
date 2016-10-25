using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidFispostedTrans
    {
        public int PostedTransKey { get; set; }
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
        public string Bankname { get; set; }
        public string PrimeAcctNum { get; set; }
        public string CardAcctNum { get; set; }
        public decimal? AuthorizeAmt { get; set; }
        public string AuthorizeCode { get; set; }
        public decimal? TxnLocalAmt { get; set; }
        public DateTime? TxnLocalDate { get; set; }
        public short? TxnSign { get; set; }
        public int? TransCurrCode { get; set; }
        public string TransCurrAlpha { get; set; }
        public int? TxnTypeCode { get; set; }
        public int? ReasonCode { get; set; }
        public int? RequestCode { get; set; }
        public int? ResponseCode { get; set; }
        public int? MatchStatusCode { get; set; }
        public int? MatchTypeCode { get; set; }
        public DateTime? InitLoadDateFlag { get; set; }
        public int? MercMccCode { get; set; }
        public string MercCurrAlpha { get; set; }
        public string MercCurrCode { get; set; }
        public string MercName { get; set; }
        public string MercNum { get; set; }
        public string PayRefNum { get; set; }
        public int? PayMethodId { get; set; }
        public decimal? SettleAmt { get; set; }
        public DateTime? WcsutcPostDate { get; set; }
        public int? SourceCode { get; set; }
        public string AcqRefNum { get; set; }
        public string AcqId { get; set; }
        public string AddrVerifyResp { get; set; }
        public decimal? AdjustAmt { get; set; }
        public string AuthorizeResp { get; set; }
        public string AvsInfo { get; set; }
        public decimal? Denomination { get; set; }
        public string DirectAccessNum { get; set; }
        public string CanProxyNum { get; set; }
        public decimal? FudgeAmt { get; set; }
        public string MatchStatusDesc { get; set; }
        public string MatchTypeDesc { get; set; }
        public string MccDesc { get; set; }
        public string MercZip { get; set; }
        public string MercCity { get; set; }
        public string MercCtryCode { get; set; }
        public string MercCtryName { get; set; }
        public string MercProv { get; set; }
        public string MercState { get; set; }
        public string MercStreet { get; set; }
        public short? Pin { get; set; }
        public string PosData { get; set; }
        public int? PosEntryCode { get; set; }
        public string PosEntryDesc { get; set; }
        public int? PurseNum { get; set; }
        public string ReasonDesc { get; set; }
        public string RequestDesc { get; set; }
        public string RespDesc { get; set; }
        public string RetrievalRefno { get; set; }
        public short? Reversed { get; set; }
        public string SourceDesc { get; set; }
        public string TermNum { get; set; }
        public string TxnTypeName { get; set; }
        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime? WcsLocalPostDate { get; set; }
        public string Comment { get; set; }
        public string ClientRefNum { get; set; }
        public string ClientSpecificId { get; set; }
        public int? ActualReqCode { get; set; }
        public string ActualReqDesc { get; set; }
        public string ClientUniqueId { get; set; }
        public string PanProxyNum { get; set; }
        public string TxnUid { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
