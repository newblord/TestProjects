namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_LoanApplicationEmployerIncome
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRIMARY_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMPLOYER_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INCOME_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IS_PRIMARY_EMPLOYER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string INCOME_TYPE_DESC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string INCOME_SOURCE_DESC { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string EMPLOYER_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(60)]
        public string DEPARTMENT { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string JOB_DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(12)]
        public string EMPLOYER_PHONE { get; set; }

        public bool? IS_DIRECT_DEPOSIT { get; set; }

        [StringLength(11)]
        public string PAY_CYCLE_SPELLED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HIRE_DATE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(9)]
        public string EMPLOY_STATUS { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMPL_ACTIVE { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMPL_DELETED { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string PAY_CYCLE { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte PAY_CYCLE_1ST { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte PAY_CYCLE_2ND { get; set; }

        [StringLength(1)]
        public string PAY_CYCLE_MONTH_INT { get; set; }

        [Key]
        [Column(Order = 16)]
        public byte PAY_CYCLE_DAY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BIWEEK_BASE { get; set; }

        public bool? PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string AMOUNT_CYCLE { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1)]
        public string AMOUNT_TYPE { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal INCOME_AMOUNT { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string VERIFY_METHOD { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string VERITY_TYPE { get; set; }

        public int? INCOME_DATE_VERIFIED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? INCOME_DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(3)]
        public string INCOME_TELLER { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INCOME_ACTIVE { get; set; }

        public int? INCOME_DATE_DELETED { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(1)]
        public string INCOME_DELETED_TELLER { get; set; }

        public int? INCOME_DATE_INACTIVE { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(1)]
        public string INCOME_INACTIVE_TELLER { get; set; }
    }
}
