namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RISREPT")]
    public partial class RISREPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RISREPT()
        {
            CollectionActions = new HashSet<CollectionAction>();
            CollectionMovements = new HashSet<CollectionMovement>();
            CollectionNotes = new HashSet<CollectionNote>();
            CpiuDetails = new HashSet<CpiuDetail>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            LegalVerifications = new HashSet<LegalVerification>();
            OptPlusCardRIPayments = new HashSet<OptPlusCardRIPayment>();
            PromiseToPays = new HashSet<PromiseToPay>();
            RepoCaseHistories = new HashSet<RepoCaseHistory>();
            RIAgingHistories = new HashSet<RIAgingHistory>();
            RiBalanceHistories = new HashSet<RiBalanceHistory>();
            RiccAutoRolls = new HashSet<RiccAutoRoll>();
            RIS = new HashSet<RI>();
            SkipTraceThreads = new HashSet<SkipTraceThread>();
        }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TLR { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AMOUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SURCHG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOLLOWUP { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int ISSUER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MANUAL_ACH_DATE { get; set; }

        [StringLength(3)]
        public string MANUAL_TELLER { get; set; }

        [Key]
        public int RISREPT_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public byte PRA { get; set; }

        public int ris_type_id { get; set; }

        public int? Ris_Audit_ID { get; set; }

        public bool STOP_PAYMENT { get; set; }

        public bool reversed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? reversed_date { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? DOS_REFNO { get; set; }

        [StringLength(50)]
        public string DOS_MIGRATED_ID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MANUAL_ACH_AMOUNT { get; set; }

        public int? MANUAL_ACH_PTP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_CALL_DATE { get; set; }

        public short? LAST_CALL_HOST_CODE { get; set; }

        public bool DO_NOT_CALL_HOME { get; set; }

        public bool DO_NOT_CALL_WORK { get; set; }

        public bool DO_NOT_CALL_CELL { get; set; }

        public bool DO_NOT_SEND_LETTERS { get; set; }

        public bool? DO_NOT_CALL_VERBAL_DNC { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(43)]
        public string REFERENCE { get; set; }

        public byte RISK_ASSESSMENT { get; set; }

        public int COLLECTION_AGENCY_KEY { get; set; }

        public int ASSIGNMENT_NUMBER { get; set; }

        [Required]
        [StringLength(3)]
        public string CR_TELLER { get; set; }

        public int REASON_FOR_ARREARS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_DCARD_ATTEMPT_DATE { get; set; }

        public int RI_URGENT_NOTE_KEY { get; set; }

        public bool KEEP_WITH_AGENCY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AD_ASTRA_ASSIGNED_DATE { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionAction> CollectionActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionMovement> CollectionMovements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionNote> CollectionNotes { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuDetail> CpiuDetails { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        public virtual Issuer Issuer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LegalVerification> LegalVerifications { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardRIPayment> OptPlusCardRIPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPay> PromiseToPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepoCaseHistory> RepoCaseHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RIAgingHistory> RIAgingHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiBalanceHistory> RiBalanceHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiccAutoRoll> RiccAutoRolls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RI> RIS { get; set; }

        public virtual RISAUDIT RISAUDIT { get; set; }

        public virtual RISTYPE RISTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceThread> SkipTraceThreads { get; set; }
    }
}
