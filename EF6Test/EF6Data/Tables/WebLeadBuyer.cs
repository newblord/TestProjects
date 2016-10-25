namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebLeadBuyer
    {
        [Key]
        public int lead_buyer_key { get; set; }

        public int? external_buyer_id { get; set; }

        [StringLength(50)]
        public string buyer_name { get; set; }

        public int? tier_amt { get; set; }

        [StringLength(50)]
        public string parent_buyer { get; set; }
    }
}
