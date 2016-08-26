namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSResponse")]
    public partial class SMSResponse
    {
        [Key]
        public int SMS_RESPONSE_KEY { get; set; }

        public int? SMS_OUTBOUND_KEY { get; set; }

        [StringLength(800)]
        public string RESPONSE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SENT_DATE { get; set; }

        [StringLength(50)]
        public string SENT_USING { get; set; }

        public bool? SENT { get; set; }

        public virtual SMSOutbound SMSOutbound { get; set; }
    }
}
