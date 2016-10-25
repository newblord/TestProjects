namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACH_HistoryCashedCheck
    {
        [Key]
        public int ACH_HISTORY_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ACH_AMOUNT { get; set; }

        public byte ACH_ATTEMPT { get; set; }

        public bool ACH_ATTEMPT2_HIST { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PROJ_SEND_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MANUAL_SEND_DATE { get; set; }

        [StringLength(3)]
        public string MANUAL_TELLER { get; set; }

        public int ACH_SENT_KEY { get; set; }

        public int? ACH_RECV_KEY { get; set; }

        [StringLength(3)]
        public string ACH_RESULT_CODE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [StringLength(20)]
        public string ABA_NO { get; set; }

        [StringLength(9)]
        public string BANK_NO { get; set; }

        public int JOBID { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public virtual ACH_Recv ACH_Recv { get; set; }

        public virtual ACH_Sent ACH_Sent { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
