namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterPrinted")]
    public partial class FormLetterPrinted
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormLetterPrinted()
        {
            FormLetterResults = new HashSet<FormLetterResult>();
        }

        [Key]
        public int FORM_LETTER_PRINTED_KEY { get; set; }

        public int FORM_LETTER_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int CUSTOMER_ADDRESS_KEY { get; set; }

        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int? FORM_LETTER_ON_DEMAND_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? PROMISE_TO_PAY_DETAIL_KEY { get; set; }

        public byte FORM_LETTER_RESULT_FILE_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VENDOR_DATE_PRINTED { get; set; }

        [StringLength(10)]
        public string VENDOR_JOB_CODE { get; set; }

        public byte? PROCESSING_STATE_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public int? DWDOCID { get; set; }

        public int? RISREPT_KEY { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }

        public virtual FormLetter FormLetter { get; set; }

        public virtual FormLetterBatch FormLetterBatch { get; set; }

        public virtual FormLetterOnDemand FormLetterOnDemand { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail { get; set; }

        public virtual PromiseToPayDetail PromiseToPayDetail { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterResult> FormLetterResults { get; set; }
    }
}
