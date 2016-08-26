namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadLocation")]
    public partial class CustomerLeadLocation
    {
        [Key]
        public int CUSTOMER_LEAD_LOCATION_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool IS_SUPERSTORE { get; set; }

        public short OF_SUPERSTORE { get; set; }

        public short? SUPERSTORE_RADIUS { get; set; }

        public short? WARNING_AGE { get; set; }

        public short? REFRESH_RATE { get; set; }

        public virtual Company Company { get; set; }
    }
}
