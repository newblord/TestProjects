namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallChatMessage")]
    public partial class WebCallChatMessage
    {
        [Key]
        public Guid WEB_UNIQUE_IDENTIFIER_KEY { get; set; }

        public Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }

        [Column(TypeName = "text")]
        public string MESSAGE { get; set; }

        public DateTime DATE_SENT { get; set; }

        public virtual WebCallChatSession WebCallChatSession { get; set; }
    }
}
