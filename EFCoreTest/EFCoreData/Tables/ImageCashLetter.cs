using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ImageCashLetter
    {
        public ImageCashLetter()
        {
            ImageCashLetterDetail = new HashSet<ImageCashLetterDetail>();
        }

        public int ImageCashLetterKey { get; set; }
        public string IclFilename { get; set; }
        public decimal OriginalSubmissionAmount { get; set; }
        public DateTime FileCreationDatetime { get; set; }
        public DateTime? FirstFileStatusDatetime { get; set; }
        public DateTime? FileProcessedDatetime { get; set; }
        public string FileValidationStatus { get; set; }
        public int CashLetterCount { get; set; }
        public int RecordCount { get; set; }
        public int ItemCount { get; set; }
        public int NumberRejected { get; set; }
        public decimal AdjustmentDollars { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<ImageCashLetterDetail> ImageCashLetterDetail { get; set; }
    }
}
