namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xsd")]
    public partial class Xsd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_MASTER_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ENABLED { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal SERVICE_COST { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smallmoney")]
        public decimal SERVICE_FEE { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal MAX_CHARGE { get; set; }

        public int? GL_ACCT_FEE { get; set; }

        public int? GL_ACCT_AMT { get; set; }

        public int? GL_ACCT_COST { get; set; }

        public int? GL_ACCT_PROFIT { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "smallmoney")]
        public decimal MIN_CHARGE { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool GOVT_ID_REQUIRED { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte SERVICE_NUM { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte DISPLAY_ORDER { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool INVENTORIED { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(2)]
        public string FUNCTION_AS { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool REQUIRE_CUST { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool PAYOUT { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool QTY_PROMPT { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool AMT_PROMPT { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool FEE_PROMPT { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SDKEY { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SMKEY { get; set; }
    }
}
