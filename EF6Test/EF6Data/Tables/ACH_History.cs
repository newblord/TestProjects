namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACH_History
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACH_History()
        {
            DDIACHHistories = new HashSet<DDIACHHistory>();
            UDDReportDetails = new HashSet<UDDReportDetail>();
        }

        [Key]
        public int ACH_HISTORY_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? ACH_AMOUNT { get; set; }

        public byte ACH_ATTEMPT { get; set; }

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

        [StringLength(20)]
        public string BANK_NO { get; set; }

        public int jobid { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? SEND_LOAN_PAYMENT_KEY { get; set; }

        public int? RECV_LOAN_PAYMENT_KEY { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public bool IS_ACH_PAID { get; set; }

        public int? REFUND_LOAN_PAYMENT_KEY { get; set; }

        public short? ACH_REASON_CODE { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [StringLength(20)]
        public string STATEMENT_ID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEES_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_CAP { get; set; }

        public bool SCHED_PAYMENT { get; set; }

        public bool IS_CREDIT { get; set; }

        public int? ACH_PRESENTMENT_KEY { get; set; }

        public virtual Company Company { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        public virtual LoanPayment LoanPayment1 { get; set; }

        public virtual LoanPayment LoanPayment2 { get; set; }

        public virtual ACHReason ACHReason { get; set; }

        public virtual ACH_Recv ACH_Recv { get; set; }

        public virtual ACH_Sent ACH_Sent { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDIACHHistory> DDIACHHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UDDReportDetail> UDDReportDetails { get; set; }
    }
}
