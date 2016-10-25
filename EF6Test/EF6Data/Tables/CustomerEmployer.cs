namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerEmployer")]
    public partial class CustomerEmployer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerEmployer()
        {
            CustomerIncomes = new HashSet<CustomerIncome>();
            LoanApplicationEmployers = new HashSet<LoanApplicationEmployer>();
        }

        [Key]
        public int CUSTOMER_EMPLOYER_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

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

        public int? ADDRESS_KEY { get; set; }

        public int? PHONE_NUMBER_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_DIRECT_DEPOSIT { get; set; }

        public bool IS_PRIMARY_EMPLOYER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EMP_SINCE { get; set; }

        [Required]
        [StringLength(1)]
        public string FULLPARTTIME { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        public byte PAY_CYCLE_DAY { get; set; }

        public byte PAY_CYCLE_1ST { get; set; }

        public byte PAY_CYCLE_2ND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BIWEEK_BASE { get; set; }

        [Required]
        [StringLength(1)]
        public string PAY_CYCLE_MONTH_INT { get; set; }

        public bool PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH { get; set; }

        public int INCOME_TYPE_KEY { get; set; }

        public int INCOME_SOURCE_KEY { get; set; }

        public int? INCOME_JOB_TYPE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_INACTIVE { get; set; }

        [Required]
        [StringLength(3)]
        public string INACTIVE_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [Required]
        [StringLength(3)]
        public string DELETED_TELLER { get; set; }

        public bool IS_DELETED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CALC_PAY_DATE { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }

        public virtual CustomerPhoneNumber CustomerPhoneNumber { get; set; }

        public virtual IncomeJobType IncomeJobType { get; set; }

        public virtual IncomeSource IncomeSource { get; set; }

        public virtual IncomeType IncomeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIncome> CustomerIncomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployers { get; set; }
    }
}
