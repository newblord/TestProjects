namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusRDFODTransition")]
    public partial class OptPlusRDFODTransition
    {
        [StringLength(16)]
        public string PRN { get; set; }

        [StringLength(8)]
        public string ENTRY_DATE { get; set; }

        [StringLength(6)]
        public string ENTRY_TIME { get; set; }

        public short? TRANS_CODE { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        public int OD_TRANSITION_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
