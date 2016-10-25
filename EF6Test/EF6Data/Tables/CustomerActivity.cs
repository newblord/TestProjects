namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerActivity")]
    public partial class CustomerActivity
    {
        [Key]
        public int CUSTOMER_ACTIVITY_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FIRST_ACTIVITY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_ACTIVITY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PRIOR_ACTIVITY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
