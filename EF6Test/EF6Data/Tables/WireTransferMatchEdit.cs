namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WireTransferMatchEdit")]
    public partial class WireTransferMatchEdit
    {
        [Key]
        public int WIRE_TRANSFER_MATCH_EDIT_KEY { get; set; }

        public int WIRE_TRANSFER_MATCH_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(40)]
        public string FIELD_NAME { get; set; }

        [StringLength(100)]
        public string OLD_VALUE { get; set; }

        [StringLength(100)]
        public string NEW_VALUE { get; set; }

        public virtual WireTransferMatch WireTransferMatch { get; set; }
    }
}
