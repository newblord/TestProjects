namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RiccUpdate
    {
        [Key]
        public int RICC_UPDATES_KEY { get; set; }

        [Required]
        [StringLength(2000)]
        public string SQL { get; set; }

        public bool PROCESSED { get; set; }

        public int? RiccHoldId { get; set; }

        [StringLength(30)]
        public string UPDATE_TABLE { get; set; }
    }
}
