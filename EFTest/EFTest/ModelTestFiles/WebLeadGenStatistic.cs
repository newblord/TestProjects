namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebLeadGenStatistic
    {
        public int Web_Lead_Gen_Key { get; set; }

        public int Num_Approved { get; set; }

        public int Num_Loans { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date_Entered { get; set; }

        [Key]
        public int WEB_LEAD_GEN_STATISTICS_KEY { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
