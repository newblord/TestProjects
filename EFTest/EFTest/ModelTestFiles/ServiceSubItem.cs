namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceSubItem")]
    public partial class ServiceSubItem
    {
        [Key]
        public int SERVICE_SUBITEM_KEY { get; set; }

        public int SERVICE_MASTER_KEY_REQUISITE { get; set; }

        public int SERVICE_MASTER_KEY_SUBITEM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual ServiceMaster ServiceMaster { get; set; }

        public virtual ServiceMaster ServiceMaster1 { get; set; }
    }
}
