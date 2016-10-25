namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountSecurity")]
    public partial class DiscountSecurity
    {
        [Key]
        public int DISCOUNT_SECURITY_KEY { get; set; }

        public int DISCOUNTS_KEY { get; set; }

        public int SECURITYGROUP_KEY { get; set; }

        public virtual DiscountMaster DiscountMaster { get; set; }

        public virtual SecurityGroup SecurityGroup { get; set; }
    }
}
