namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusBinService")]
    public partial class OptPlusBinService
    {
        [Key]
        public int OPT_PLUS_BIN_SERVICE_KEY { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int OPT_PLUS_BIN_KEY { get; set; }
    }
}
