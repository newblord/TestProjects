namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditRptPrint")]
    public partial class CreditRptPrint
    {
        [Key]
        public int CRP_key { get; set; }

        public int Credit_Rpt_Key { get; set; }

        public int? LineOrder { get; set; }

        public int? PrintOrder { get; set; }

        [StringLength(300)]
        public string ReportLine { get; set; }
    }
}
