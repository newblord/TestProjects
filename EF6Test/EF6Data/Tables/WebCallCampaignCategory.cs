namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCampaignCategory")]
    public partial class WebCallCampaignCategory
    {
        [Key]
        public int WEB_CALL_CAMPAIGN_CATEGORY_KEY { get; set; }

        public int WEB_CALL_CAMPAIGN_KEY { get; set; }

        public int WEB_CALL_CATEGORY_KEY { get; set; }

        public short SORT_PRIORITY { get; set; }

        public virtual WebCallCampaign WebCallCampaign { get; set; }

        public virtual WebCallCategory WebCallCategory { get; set; }
    }
}
