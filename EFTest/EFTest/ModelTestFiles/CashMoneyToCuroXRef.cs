namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashMoneyToCuroXRef")]
    public partial class CashMoneyToCuroXRef
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CLIENT_KEY { get; set; }

        public DateTime? DATE_ENTERED { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
