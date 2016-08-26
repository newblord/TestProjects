namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CollBonusTask
    {
        [StringLength(3)]
        public string tellerid { get; set; }

        public byte? product { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tdate { get; set; }

        public byte? task { get; set; }

        public int? riage { get; set; }

        [Key]
        public int COLL_BONUS_TASKS_KEY { get; set; }
    }
}
