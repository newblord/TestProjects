namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailAcct")]
    public partial class TransDetailAcct
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_ACCT_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        public byte ACCT_TYPE { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT { get; set; }

        public int GL_ACCT { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
