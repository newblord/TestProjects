namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerPhoneNumberEdit")]
    public partial class CustomerPhoneNumberEdit
    {
        [Key]
        public int CUSTOMER_PHONE_NUMBER_EDIT_KEY { get; set; }

        public int CUSTOMER_PHONE_NUMBER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(30)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(50)]
        public string NEW_VALUE { get; set; }

        public short? CHANGED_AT_LOCATION { get; set; }

        public virtual CustomerPhoneNumber CustomerPhoneNumber { get; set; }
    }
}
