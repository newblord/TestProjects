namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectionMovement")]
    public partial class CollectionMovement
    {
        [Key]
        public int COLLECTION_MOVEMENT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int RISREPT_KEY { get; set; }

        public int AUDIT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOLLOWUP_DATE { get; set; }

        public int? COLLECTION_AGENCY_KEY { get; set; }

        public byte? ASSIGNMENT_NUMBER { get; set; }

        [StringLength(3)]
        public string CR_TELLER { get; set; }

        public int? REASON_FOR_ARREARS_KEY { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
