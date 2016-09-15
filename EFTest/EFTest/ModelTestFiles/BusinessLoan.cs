namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessLoan")]
    public partial class BusinessLoan
    {
        [Key]
        public int BUSINESS_LOAN_KEY { get; set; }

        public int CUSTOMER_BUSINESS_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string BUSINESS_NAME { get; set; }

        public byte BUSINESS_TYPE_CODE { get; set; }

        public byte LEGAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TAX_ID_NUM { get; set; }

        [Required]
        [StringLength(12)]
        public string BUSINESS_PHONE_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BUSINESS_START_DATE { get; set; }

        public short NUM_EMPLOYEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VER_MONTHLY_NET_INC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VER_BANK_DEPOSITS { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_PURPOSE { get; set; }

        public bool USE_HOME_ADDRESS { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_NUM { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_POST_DIR { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_PRE_DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUFFIX { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUITE { get; set; }

        [Required]
        [StringLength(15)]
        public string ADDR_SUITE_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        public virtual CustomerBusiness CustomerBusiness { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
