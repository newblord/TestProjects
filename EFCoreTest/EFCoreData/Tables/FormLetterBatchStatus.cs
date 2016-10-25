using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterBatchStatus
    {
        public FormLetterBatchStatus()
        {
            FormLetterBatch = new HashSet<FormLetterBatch>();
        }

        public byte FormLetterBatchStatusKey { get; set; }
        public string StatusDesc { get; set; }

        public virtual ICollection<FormLetterBatch> FormLetterBatch { get; set; }
    }
}
