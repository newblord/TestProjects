namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuerEdit")]
    public partial class IssuerEdit
    {
        [Key]
        public int ISSUER_EDIT_KEY { get; set; }

        public int ISSUER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(25)]
        public string FIELD_NAME { get; set; }

        [StringLength(150)]
        public string OLD_VALUE { get; set; }

        [StringLength(150)]
        public string NEW_VALUE { get; set; }

        public virtual Issuer Issuer { get; set; }
    }
}
