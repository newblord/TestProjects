namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDDISReasonCodeMapping")]
    public partial class AUDDISReasonCodeMapping
    {
        [Key]
        [StringLength(1)]
        public string AUDDIS_REASON_CODE { get; set; }

        public int DDI_STATUS_CODE { get; set; }
    }
}
