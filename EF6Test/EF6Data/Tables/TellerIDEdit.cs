namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerIDEdit")]
    public partial class TellerIDEdit
    {
        [Key]
        public int TELLER_ID_EDIT_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short OLD_SECURITYGROUP_KEY { get; set; }

        public short NEW_SECURITYGROUP_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }
    }
}
