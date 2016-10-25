namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCSRReportColumnRARR")]
    public partial class WebCallCSRReportColumnRARR
    {
        [Key]
        public int Web_Call_CSRReport_ColumnRARR_Key { get; set; }

        public int Web_Call_CSRReport_Columns_Key { get; set; }

        public int Web_Call_RARR_Key { get; set; }

        public virtual WebCallCSRReportColumn WebCallCSRReportColumn { get; set; }
    }
}
