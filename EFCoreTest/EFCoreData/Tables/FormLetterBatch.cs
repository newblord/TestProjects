using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterBatch
    {
        public FormLetterBatch()
        {
            FormLetterOnDemand = new HashSet<FormLetterOnDemand>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            FormLetterResult = new HashSet<FormLetterResult>();
        }

        public int FormLetterBatchKey { get; set; }
        public DateTime BatchDate { get; set; }
        public string Teller { get; set; }
        public string UploadOrDownload { get; set; }
        public bool IsAdAstra { get; set; }
        public byte FormLetterBatchStatusKey { get; set; }
        public DateTime? BatchStatusDatetime { get; set; }
        public byte? BatchStep { get; set; }

        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemand { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<FormLetterResult> FormLetterResult { get; set; }
        public virtual FormLetterBatchStatus FormLetterBatchStatusKeyNavigation { get; set; }
    }
}
