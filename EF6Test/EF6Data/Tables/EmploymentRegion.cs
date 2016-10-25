namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmploymentRegion
    {
        [Key]
        [Column(Order = 0)]
        public int EMPLOYMENT_REGION_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string NAME { get; set; }

        [StringLength(256)]
        public string EMAIL_RECIPIENTS { get; set; }
    }
}
