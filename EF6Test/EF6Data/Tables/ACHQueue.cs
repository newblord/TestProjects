namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHQueue")]
    public partial class ACHQueue
    {
        [Key]
        public int ACH_QUEUE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_TO_SEND { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(9)]
        public string ABA { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCOUNT { get; set; }

        public short ACH_REASON_CODE { get; set; }

        public bool IS_CREDIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        public virtual BANK BANK { get; set; }

        public virtual ACHReason ACHReason { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
