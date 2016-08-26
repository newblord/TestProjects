namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DiscountLocation
    {
        [Key]
        public int DISCOUNT_LOCATIONS_KEY { get; set; }

        public int DISCOUNTS_KEY { get; set; }

        public short LOCATION { get; set; }

        public virtual Company Company { get; set; }

        public virtual DiscountMaster DiscountMaster { get; set; }
    }
}
