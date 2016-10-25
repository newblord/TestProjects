namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusExportInitGL")]
    public partial class OptPlusExportInitGL
    {
        [Key]
        public int OPT_PLUS_EXPORT_INIT_GL_KEY { get; set; }

        [StringLength(10)]
        public string OPT_PLUS_TRANS_CODE { get; set; }

        [StringLength(4)]
        public string TRECS_TRANS_CODE { get; set; }

        public int D2JE1D_POS { get; set; }

        public int D2JE1C_POS { get; set; }

        public int D2JE2D_POS { get; set; }

        public int D2JE2C_POS { get; set; }

        public int D2JE1D_NEG { get; set; }

        public int D2JE1C_NEG { get; set; }

        public int D2JE2D_NEG { get; set; }

        public int D2JE2C_NEG { get; set; }

        public int PREPAID_CARD_BIN_KEY { get; set; }

        public virtual PrepaidCardBin PrepaidCardBin { get; set; }
    }
}
