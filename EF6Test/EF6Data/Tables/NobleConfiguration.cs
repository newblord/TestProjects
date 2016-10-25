namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NobleConfiguration")]
    public partial class NobleConfiguration
    {
        [Key]
        public int NOBLE_CONFIG_KEY { get; set; }

        [StringLength(50)]
        public string COLLECTIONS_EXCLUSION_TABLE_NAME { get; set; }

        [StringLength(50)]
        public string COLLECTIONS_TABLE_NAME { get; set; }

        [StringLength(50)]
        public string COURTESY_TABLE_NAME { get; set; }

        [StringLength(50)]
        public string INTERNET_LENDING_TABLE_NAME { get; set; }

        public int? INTERNET_LENDING_LIST_ID { get; set; }

        [StringLength(2)]
        public string TABLE_NAME_PREFIX { get; set; }

        public byte TIME_OFFSET_FROM_NOBLE { get; set; }

        [StringLength(3)]
        public string TELLER_ID { get; set; }
    }
}
