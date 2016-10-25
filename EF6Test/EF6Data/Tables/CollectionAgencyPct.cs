namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectionAgencyPct")]
    public partial class CollectionAgencyPct
    {
        [Key]
        public int COLLECTION_AGENCY_PCT_KEY { get; set; }

        public int COLLECTION_AGENCY_KEY { get; set; }

        public byte ASSIGNMENT_NUMBER { get; set; }

        public decimal PCT { get; set; }

        [Column(TypeName = "date")]
        public DateTime START_DATE { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual CollectionAgency CollectionAgency { get; set; }
    }
}
