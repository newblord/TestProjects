namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferFundsInterStore")]
    public partial class TransferFundsInterStore
    {
        [Key]
        [Column(Order = 0)]
        public int TRANSFER_FUNDS_INTER_STORE_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FROM_TRANSFER_FUNDS_KEY { get; set; }

        public int? FROM_TRANS_DETAIL_CASH_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FROM_LOCATION { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TO_LOCATION { get; set; }

        public int? TO_TRANSFER_FUNDS_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal BASE_CURRENCY_VALUE { get; set; }

        public int? SERVICE_MASTER_KEY { get; set; }

        public int? SERVICE_QTY { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual TransferFund TransferFund { get; set; }

        public virtual TransferFund TransferFund1 { get; set; }
    }
}
