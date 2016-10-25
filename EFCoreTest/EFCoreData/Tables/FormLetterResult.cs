using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterResult
    {
        public int FormLetterResultKey { get; set; }
        public int FormLetterPrintedKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public int CustomerKey { get; set; }
        public int? CustomerAddressKey { get; set; }
        public byte FormLetterResultFileType { get; set; }
        public string FormLetterResultErrorCode { get; set; }
        public string FormLetterResultFfwdCode { get; set; }
        public string FormLetterResultDpvCode { get; set; }
        public string FormLetterResultRetCode { get; set; }
        public string MailingSvcJobNum { get; set; }

        public virtual CustomerAddress CustomerAddressKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual FormLetterBatch FormLetterBatchKeyNavigation { get; set; }
        public virtual FormLetterPrinted FormLetterPrintedKeyNavigation { get; set; }
    }
}
