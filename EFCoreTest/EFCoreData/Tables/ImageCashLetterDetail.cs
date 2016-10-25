using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ImageCashLetterDetail
    {
        public ImageCashLetterDetail()
        {
            ImageCashLetterBundle = new HashSet<ImageCashLetterBundle>();
        }

        public int ImageCashLetterDetailKey { get; set; }
        public int ImageCashLetterKey { get; set; }
        public short Location { get; set; }
        public string CashLetterStatus { get; set; }
        public int RejectedItemCount { get; set; }
        public decimal RejectedDollars { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<ImageCashLetterBundle> ImageCashLetterBundle { get; set; }
        public virtual ImageCashLetter ImageCashLetterKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
