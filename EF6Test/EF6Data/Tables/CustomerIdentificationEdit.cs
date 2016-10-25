namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerIdentificationEdit")]
    public partial class CustomerIdentificationEdit
    {
        [Key]
        public int CUSTOMER_IDENTIFICATION_EDIT_KEY { get; set; }

        public int CUSTOMER_IDENTIFICATION_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(40)]
        public string FIELD_NAME { get; set; }

        [StringLength(150)]
        public string OLD_VALUE { get; set; }

        [StringLength(150)]
        public string NEW_VALUE { get; set; }

        public virtual CustomerIdentification CustomerIdentification { get; set; }
    }
}
