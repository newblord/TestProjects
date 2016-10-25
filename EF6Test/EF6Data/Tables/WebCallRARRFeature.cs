namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallRARRFeature
    {
        [Key]
        public int WEB_CALL_RARR_FEATURES_KEY { get; set; }

        public int WEB_CALL_RARR_KEY { get; set; }

        public int WEB_CALL_FEATURES_KEY { get; set; }

        public bool FEATURE_ENABLE { get; set; }

        public bool SupDualAuthEnabled { get; set; }

        public bool CSRDualAuthEnabled { get; set; }

        public virtual WebCallFeature WebCallFeature { get; set; }

        public virtual WebCallRARR WebCallRARR { get; set; }
    }
}
