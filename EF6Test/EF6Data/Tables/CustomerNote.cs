namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerNote")]
    public partial class CustomerNote
    {
        [Key]
        public int CUSTOMER_NOTE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RTF_NOTE { get; set; }

        public bool IS_FLASH { get; set; }

        public bool IS_DELETED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_DELETED { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        public int? NEW_CUSTOMER_NOTE_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
