namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PushNotification")]
    public partial class PushNotification
    {
        [Key]
        public int PUSH_NOTIFICATION_KEY { get; set; }

        public int VISITOR_DEVICE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime DATE_UPDATED { get; set; }

        public byte STATUS { get; set; }

        [StringLength(200)]
        public string ARGUMENTS { get; set; }

        public byte TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_SCHEDULED { get; set; }

        public virtual VisitorDevice VisitorDevice { get; set; }
    }
}
