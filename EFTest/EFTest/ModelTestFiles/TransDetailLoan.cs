namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailLoan")]
    public partial class TransDetailLoan
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_FROM { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TO { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        public byte LOAN_CNT { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
