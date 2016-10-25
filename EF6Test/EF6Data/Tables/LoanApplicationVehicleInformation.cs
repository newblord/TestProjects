namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanApplicationVehicleInformation")]
    public partial class LoanApplicationVehicleInformation
    {
        [Key]
        public int LOAN_APPLICATION_VEHICLE_INFORMATION_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "money")]
        public decimal VEH_WHOLESALE { get; set; }

        public int VEH_MILEAGE { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_CONDITION { get; set; }

        [Required]
        [StringLength(10)]
        public string VEH_PLATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VEH_STICKER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VEH_REG_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VEH_REG_EXPIRE { get; set; }

        [Required]
        [StringLength(2)]
        public string VEH_REG_STATE { get; set; }

        [Required]
        [StringLength(15)]
        public string VEH_TITLE_NUM { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_ODO_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string LEGAL_STATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string STATE_CUST_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string INS_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string INS_PHONE { get; set; }

        public bool INS_FULL_COVER { get; set; }

        [Required]
        [StringLength(40)]
        public string INS_POLICY_NUM { get; set; }

        public bool PAY_VERIFIED { get; set; }

        [StringLength(59)]
        public string AND_OR_NAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LIEN_BALANCE { get; set; }

        [StringLength(20)]
        public string LIEN_ACCT_NUM { get; set; }

        [StringLength(40)]
        public string VEH_VIN { get; set; }

        [StringLength(40)]
        public string VEH_MAKE { get; set; }

        [StringLength(100)]
        public string VEH_MODEL { get; set; }

        [StringLength(100)]
        public string VEH_BODY { get; set; }

        [StringLength(40)]
        public string VEH_ENGINE { get; set; }

        [StringLength(40)]
        public string VEH_TRANS { get; set; }

        [StringLength(40)]
        public string VEH_DRIVE { get; set; }

        public short VEH_YEAR { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VEH_RETAIL { get; set; }

        public bool IS_CLEAR_TITLE { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
