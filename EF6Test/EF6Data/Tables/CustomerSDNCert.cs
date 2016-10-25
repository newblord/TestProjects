namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerSDNCert")]
    public partial class CustomerSDNCert
    {
        [Key]
        public int SDNCERT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public bool DIFF_DOB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public bool DIFF_ADDRESS { get; set; }

        public bool DIFF_NUMBER { get; set; }

        public bool OTHER { get; set; }

        [StringLength(100)]
        public string OTHER_DESC { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }
    }
}
