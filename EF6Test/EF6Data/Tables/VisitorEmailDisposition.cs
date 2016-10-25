namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorEmailDisposition")]
    public partial class VisitorEmailDisposition
    {
        [Key]
        public int VISITOR_EMAIL_DISPOSITION_KEY { get; set; }

        public int VISITOR_EMAIL_KEY { get; set; }

        public int EMAIL_DISPOSITION_KEY { get; set; }

        public DateTime DISPOSITION_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual EmailDisposition EmailDisposition { get; set; }

        public virtual VisitorEmail VisitorEmail { get; set; }
    }
}
