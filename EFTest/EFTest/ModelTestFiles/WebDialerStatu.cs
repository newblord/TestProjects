namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebDialerStatu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WEB_DIALER_STATUS_KEY { get; set; }

        public short STATUS { get; set; }

        public DateTime DATE_MODIFIED { get; set; }
    }
}
