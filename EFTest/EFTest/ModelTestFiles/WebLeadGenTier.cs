namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebLeadGenTier
    {
        public int Web_Lead_Gen_Key { get; set; }

        public int Score { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        [Key]
        public int WEB_LEAD_GEN_TIERS_KEY { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
