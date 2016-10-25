namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositDebitCardDetail")]
    public partial class DepositDebitCardDetail
    {
        [Key]
        public int DEPOSIT_DEBIT_CARD_DETAIL_KEY { get; set; }

        public int DEPOSIT_DEBIT_CARD_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public bool REVERSED { get; set; }

        [StringLength(3)]
        public string REVERSED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public virtual DepositDebitCard DepositDebitCard { get; set; }
    }
}
