namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorHistory")]
    public partial class VisitorHistory
    {
        [Key]
        public int VISITOR_HISTORY_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        [Required]
        [StringLength(15)]
        public string IP_ADDRESS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1000)]
        public string PAGE_NAME { get; set; }

        [Required]
        [StringLength(255)]
        public string METHOD_CALL { get; set; }

        [StringLength(38)]
        public string SESSION_GUID { get; set; }

        public DateTime? DATE_ENTERED_WITH_SECONDS { get; set; }

        public long? WEB_VISIT_KEY { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
