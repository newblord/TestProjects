namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store_Windows
    {
        [Key]
        public int Store_Windows_Key { get; set; }

        public short Location { get; set; }

        [Required]
        [StringLength(100)]
        public string Computer_Name { get; set; }

        [StringLength(1000)]
        public string Citrix_Name { get; set; }

        [StringLength(500)]
        public string REPORT { get; set; }

        [StringLength(500)]
        public string RECEIPT { get; set; }

        [StringLength(500)]
        public string AGREEMENT { get; set; }

        [StringLength(500)]
        public string DOTMATRIX { get; set; }

        public short? MONEY_ORDERS { get; set; }

        public bool SHARED_PRINTERS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SYSTEM_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SYSTEM_DATE_SET { get; set; }

        public short MO_FORMS_REMAINING { get; set; }

        [StringLength(2)]
        public string WINDOWS_VERSION { get; set; }

        [StringLength(200)]
        public string TELLER_KEYBOARD { get; set; }

        [StringLength(200)]
        public string CUSTOMER_KEYBOARD { get; set; }

        [StringLength(6)]
        public string MONEY_ORDER_COM_PORT { get; set; }
    }
}
