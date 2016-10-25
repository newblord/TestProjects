using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achdetail
    {
        public int AchDetailKey { get; set; }
        public string RecordType { get; set; }
        public string TransCode { get; set; }
        public string ParticipantRoutingNumber { get; set; }
        public short? ParticipantRoutingNumberCheckDigit { get; set; }
        public string ParticipantAccountNumber { get; set; }
        public string TransactionAmount { get; set; }
        public string IdenitificationNumber { get; set; }
        public string ReceiverName { get; set; }
        public string DiscretionaryData { get; set; }
        public string AddendaRecord { get; set; }
        public string TraceNumber { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public bool? Selected { get; set; }
        public bool? Processed { get; set; }
        public int? AchReturnCodeKey { get; set; }
        public int AchBatchHeaderKey { get; set; }

        public virtual AchdetailAddendum AchdetailAddendum { get; set; }
        public virtual AchbatchHeader AchBatchHeaderKeyNavigation { get; set; }
    }
}
