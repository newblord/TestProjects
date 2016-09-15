namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Notes_LoanPayment
    {
        [Key]
        [Column(Order = 0)]
        public DateTime NOTEDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smallmoney")]
        public decimal DOLLARAMOUNT { get; set; }

        [StringLength(568)]
        public string NOTETEXT { get; set; }

        [StringLength(36)]
        public string TELLERNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(43)]
        public string CUSTOM1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string CUSTOM2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string CUSTOM3 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOANPAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PAID_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAYMENT_METHOD { get; set; }

        public int? RISREPT_KEY { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte TRANS_CODE { get; set; }
    }
}
