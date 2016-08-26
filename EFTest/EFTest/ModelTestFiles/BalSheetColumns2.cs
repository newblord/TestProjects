namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BalSheetColumns2
    {
        [Key]
        public int BSC_KEY { get; set; }

        public int BALSHEET_KEY { get; set; }

        public int GL_ACCT { get; set; }

        public byte ACCT_TYPE { get; set; }

        [Column(TypeName = "money")]
        public decimal DB_AMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal CR_AMOUNT { get; set; }

        [StringLength(60)]
        public string ACCT_TYPE_DESC { get; set; }

        public virtual BalSheet2 BalSheet2 { get; set; }
    }
}
