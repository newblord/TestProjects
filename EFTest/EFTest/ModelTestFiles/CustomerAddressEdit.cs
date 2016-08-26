namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAddressEdit")]
    public partial class CustomerAddressEdit
    {
        [Key]
        public int CUSTOMER_ADDRESS_EDIT_KEY { get; set; }

        public int CUSTOMER_ADDRESS_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(30)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(150)]
        public string NEW_VALUE { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }
    }
}
