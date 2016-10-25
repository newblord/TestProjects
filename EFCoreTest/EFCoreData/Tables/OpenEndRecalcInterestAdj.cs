using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndRecalcInterestAdj
    {
        public int OpenEndRecalcInterestAdjKey { get; set; }
        public int OpenEndInterestKey { get; set; }
        public int LoanKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? InterestDate { get; set; }
        public DateTime CInterestDate { get; set; }
        public decimal InterestAdded { get; set; }
        public decimal CInterestAdded { get; set; }
        public decimal CabInterestAdded { get; set; }
        public decimal CCabInterestAdded { get; set; }
        public decimal PrincDue { get; set; }
        public decimal CPrincDue { get; set; }
        public decimal LoanBalance { get; set; }
        public decimal CLoanBalance { get; set; }
        public decimal CabFeeBalance { get; set; }
        public decimal CCabFeeBalance { get; set; }
        public decimal CollectionsAmt { get; set; }
        public decimal CCollectionsAmt { get; set; }
    }
}
