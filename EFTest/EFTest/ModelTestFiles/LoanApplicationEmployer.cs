namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationEmployer")]
    public partial class LoanApplicationEmployer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanApplicationEmployer()
        {
            LoanApplicationIncomes = new HashSet<LoanApplicationIncome>();
        }

        [Key]
        public int LOAN_APPLICATION_EMPLOYER_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYER_NAME { get; set; }

        [Required]
        [StringLength(60)]
        public string DEPARTMENT { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        public int? LOAN_APPLICATION_ADDRESS_KEY { get; set; }

        public bool? IS_DIRECT_DEPOSIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EMP_SINCE { get; set; }

        [Required]
        [StringLength(1)]
        public string FULLPARTTIME { get; set; }

        [Required]
        [StringLength(12)]
        public string PHONE_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string PHONE_EXT { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        public byte PAY_CYCLE_DAY { get; set; }

        public byte PAY_CYCLE_1ST { get; set; }

        public byte PAY_CYCLE_2ND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BIWEEK_BASE { get; set; }

        [StringLength(1)]
        public string PAY_CYCLE_MONTH_INT { get; set; }

        public bool? PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH { get; set; }

        public int? INCOME_TYPE_KEY { get; set; }

        public int? INCOME_SOURCE_KEY { get; set; }

        public int? INCOME_JOB_TYPE_KEY { get; set; }

        public bool IS_PRIMARY_EMPLOYER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? JOB_TYPE_VERIFIED_DATE { get; set; }

        public int? CUSTOMER_EMPLOYER_KEY { get; set; }

        public virtual CustomerEmployer CustomerEmployer { get; set; }

        public virtual IncomeJobType IncomeJobType { get; set; }

        public virtual IncomeSource IncomeSource { get; set; }

        public virtual IncomeType IncomeType { get; set; }

        public virtual LoanApplicationAddress LoanApplicationAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationIncome> LoanApplicationIncomes { get; set; }
    }
}
