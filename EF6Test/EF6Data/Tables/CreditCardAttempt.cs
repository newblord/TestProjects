namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CreditCardAttempt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CREDIT_CARD_TRANS_KEY { get; set; }

        public bool PAID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte TRANS_TYPE { get; set; }

        public bool IS_RECURRING { get; set; }

        [StringLength(20)]
        public string CARD_NUMBER { get; set; }

        [StringLength(40)]
        public string TOKEN { get; set; }
    }
}
