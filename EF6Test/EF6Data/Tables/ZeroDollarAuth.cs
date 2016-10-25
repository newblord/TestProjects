namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZeroDollarAuth")]
    public partial class ZeroDollarAuth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CREDIT_CARD_TRANS_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        public bool CREDITCARD_COOLING_OFF { get; set; }

        public bool VISITOR_COOLING_OFF { get; set; }

        public bool IS_ACCT_VERIFY_ONLY { get; set; }

        public virtual CreditCardTran CreditCardTran { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
