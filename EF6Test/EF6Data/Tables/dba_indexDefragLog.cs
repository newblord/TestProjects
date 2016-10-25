namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dba_indexDefragLog
    {
        [Key]
        public int indexDefrag_id { get; set; }

        public int databaseID { get; set; }

        [Required]
        [StringLength(128)]
        public string databaseName { get; set; }

        public int objectID { get; set; }

        [Required]
        [StringLength(128)]
        public string objectName { get; set; }

        public int indexID { get; set; }

        [Required]
        [StringLength(128)]
        public string indexName { get; set; }

        public short partitionNumber { get; set; }

        public double fragmentation { get; set; }

        public int page_count { get; set; }

        public DateTime dateTimeStart { get; set; }

        public int durationSeconds { get; set; }
    }
}
