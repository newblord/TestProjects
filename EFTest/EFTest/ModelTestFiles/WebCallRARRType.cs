namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRARRType")]
    public partial class WebCallRARRType
    {
        [Key]
        [Column(Order = 0)]
        public int WEB_CALL_RARR_TYPE_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool DELETED { get; set; }
    }
}
