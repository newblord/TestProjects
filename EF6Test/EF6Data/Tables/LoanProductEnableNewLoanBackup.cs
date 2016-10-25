namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductEnableNewLoanBackup")]
    public partial class LoanProductEnableNewLoanBackup
    {
        [Key]
        [Column(Order = 0)]
        public int LOAN_PRODUCT_ENABLE_NEW_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_TILA_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime END_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ENABLE_AGREEMENT_NUMBER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NEXT_AGREEMENT_NUMBER { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool LEGACY_IS_ENABLED { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool LEGACY_IS_EASYPAY_ENABLED { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool LEGACY_IS_BUSINESS_LOAN_ENABLED { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool LEGACY_IS_EXPRESS_ENABLED { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public short? LIEN_ADDRESS_LOCATION { get; set; }
    }
}
