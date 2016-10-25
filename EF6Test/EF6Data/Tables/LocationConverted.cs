namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationConverted")]
    public partial class LocationConverted
    {
        [Key]
        public int LOCATION_CONVERTED_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        public int LOCATION { get; set; }

        public bool RUN_OPEN_LOAN_CHECK { get; set; }
    }
}
