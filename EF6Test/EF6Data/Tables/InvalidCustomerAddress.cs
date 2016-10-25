namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvalidCustomerAddress")]
    public partial class InvalidCustomerAddress
    {
        [Key]
        public int ICA_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int? CUSTOMER_ADDRESS_KEY { get; set; }

        public byte REASON { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_NUM { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_ADDR_POST_DIR { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_ADDR_PRE_DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string HOME_ADDR_STREET { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_SUFFIX { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ADDR_SUITE { get; set; }

        [Required]
        [StringLength(15)]
        public string HOME_ADDR_SUITE_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string HOME_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string HOME_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string HOME_ZIPCODE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(95)]
        public string HOME_ADDRESS { get; set; }
    }
}
