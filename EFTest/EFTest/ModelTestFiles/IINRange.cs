namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IINRange")]
    public partial class IINRange
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IINRangeId { get; set; }

        public short CsId { get; set; }

        public short SetId { get; set; }

        public short Sort { get; set; }

        public int RangeFrom { get; set; }

        public int RangeTo { get; set; }

        public bool Valid { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IssReq { get; set; }

        public byte IssLen { get; set; }

        public byte IssPos { get; set; }

        public bool StDtReq { get; set; }

        public byte StDtFmt { get; set; }

        public byte StDtPos { get; set; }

        public bool StDtChk { get; set; }

        public bool ExDtChk { get; set; }

        public bool RefStDtChk { get; set; }

        public bool RefExDtChk { get; set; }

        [Required]
        [StringLength(50)]
        public string PanLen { get; set; }

        public byte CpcOpt { get; set; }

        [Required]
        [StringLength(19)]
        public string Mask { get; set; }

        public byte NCpcCsId { get; set; }

        public bool Purch { get; set; }

        public bool Ref { get; set; }

        public bool Pwcb { get; set; }

        public bool CashAdv { get; set; }

        public bool AuthOnly { get; set; }

        public bool ChrgOnly { get; set; }

        public bool Recur { get; set; }

        public bool EPurch { get; set; }

        public bool ERef { get; set; }

        public bool PayerAuth { get; set; }

        public bool OlTxn { get; set; }

        public bool KeyPan { get; set; }

        public bool KeyPanRef { get; set; }

        public bool MailPurch { get; set; }

        public bool MailRef { get; set; }

        public bool TelPurch { get; set; }

        public bool TelRef { get; set; }

        public byte Uat { get; set; }

        public byte Uat2 { get; set; }

        public bool Vr { get; set; }

        public bool ZeroPreAuth { get; set; }

        public bool ForceOnline { get; set; }

        public bool RecNoExp { get; set; }

        public bool Avs { get; set; }

        public bool Csc { get; set; }

        public byte CscLen { get; set; }

        [Required]
        [StringLength(10)]
        public string CscLen2 { get; set; }

        public bool CpcOnly { get; set; }

        public bool AnsiTk2 { get; set; }

        public byte AnsiTk2Len { get; set; }

        public byte AnsiTk2StDtPos { get; set; }

        public bool NoChkServCode { get; set; }

        public bool NoChkLuhn { get; set; }

        public bool NoChkPan { get; set; }

        public bool Ca2Purch { get; set; }

        public bool IccOnly { get; set; }

        public short NoIntCbk { get; set; }

        public short AuthCodeLen { get; set; }

        public short OlStDtChk { get; set; }

        public short OlExDtChk { get; set; }

        public short OlRefStDtChk { get; set; }

        public short OlRefExDtChk { get; set; }

        public bool OlNoChkServCode { get; set; }

        public bool OlNoChkLuhn { get; set; }

        public bool OlNoChkPan { get; set; }

        public bool ExDtReq { get; set; }
    }
}
