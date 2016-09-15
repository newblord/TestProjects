namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreClosedDetail")]
    public partial class StoreClosedDetail
    {
        [Key]
        public int STORECLOSEDDETAIL_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime CLOSEDATE { get; set; }

        public int LOCATION { get; set; }
    }
}
