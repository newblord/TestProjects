namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorApiAuthorization")]
    public partial class VisitorApiAuthorization
    {
        [Key]
        public int VISITOR_API_AUTHORIZATION_KEY { get; set; }

        public int API_APPLICATION_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        public DateTime DATE_TOKEN_EXPIRES { get; set; }

        [Required]
        [StringLength(75)]
        public string PIN { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public Guid? TOKEN { get; set; }

        public int? VISITOR_DEVICE_KEY { get; set; }

        public virtual ApiApplication ApiApplication { get; set; }

        public virtual Visitor Visitor { get; set; }

        public virtual VisitorDevice VisitorDevice { get; set; }
    }
}
