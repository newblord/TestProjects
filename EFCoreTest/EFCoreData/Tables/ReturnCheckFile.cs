using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ReturnCheckFile
    {
        public ReturnCheckFile()
        {
            ReturnCheckDetail = new HashSet<ReturnCheckDetail>();
        }

        public int ReturnCheckFileKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int CurrencyKey { get; set; }
        public int FileCreationNumber { get; set; }
        public DateTime FileCreationDate { get; set; }
        public int TotalRecords { get; set; }
        public decimal TotalChargebacks { get; set; }

        public virtual ICollection<ReturnCheckDetail> ReturnCheckDetail { get; set; }
    }
}
