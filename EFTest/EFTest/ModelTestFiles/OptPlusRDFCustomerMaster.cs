namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusRDFCustomerMaster")]
    public partial class OptPlusRDFCustomerMaster
    {
        [StringLength(15)]
        public string PROGRAM_ID { get; set; }

        [StringLength(8)]
        public string ISSUE_DATE { get; set; }

        [StringLength(50)]
        public string PRIMARY_ID { get; set; }

        [StringLength(5)]
        public string PRIMARY_IDTYPE { get; set; }

        [StringLength(20)]
        public string FIRST_NAME { get; set; }

        [StringLength(20)]
        public string LAST_NAME { get; set; }

        [StringLength(40)]
        public string ADDRESS_LINE1 { get; set; }

        [StringLength(40)]
        public string ADDRESS_LINE2 { get; set; }

        [StringLength(20)]
        public string CITY { get; set; }

        [StringLength(2)]
        public string STATE { get; set; }

        [StringLength(9)]
        public string ZIPCODE { get; set; }

        [StringLength(10)]
        public string HOME_PHONE { get; set; }

        [StringLength(10)]
        public string WORK_PHONE { get; set; }

        [StringLength(5)]
        public string STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_BAL_AMT { get; set; }

        [StringLength(1)]
        public string CURR_BAL_SIGN { get; set; }

        [StringLength(8)]
        public string DATE_ENTERED { get; set; }

        [StringLength(8)]
        public string NEG_BAL_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEG_BAL_FEE_AMT { get; set; }

        public bool? IS_RELOADABLE { get; set; }

        [StringLength(30)]
        public string ACCOUNT_ID { get; set; }

        [StringLength(5)]
        public string ACCOUNT_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AVAIL_BAL_AMT { get; set; }

        [StringLength(1)]
        public string AVAIL_BAL_SIGN { get; set; }

        [StringLength(30)]
        public string EXT_ACCT_NUM { get; set; }

        [StringLength(8)]
        public string LAST_TRANS_DATE { get; set; }

        [StringLength(8)]
        public string DOB { get; set; }

        public short? BILL_CYCLE_DAY { get; set; }

        [StringLength(20)]
        public string LOCATION_ID { get; set; }

        [StringLength(20)]
        public string AGENTUSER_ID { get; set; }

        [StringLength(50)]
        public string SECONDARY_ID { get; set; }

        [StringLength(5)]
        public string SECONDARY_IDTYPE { get; set; }

        [StringLength(50)]
        public string USER_DATA1 { get; set; }

        [StringLength(50)]
        public string USER_DATA2 { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        public int CUSTOMER_MASTER_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
