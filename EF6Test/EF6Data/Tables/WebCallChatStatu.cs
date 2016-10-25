namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallChatStatu
    {
        [Key]
        public int WEB_CALL_CHAT_STATUS_KEY { get; set; }

        public Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }

        [Required]
        [StringLength(500)]
        public string MESSAGE { get; set; }

        public int STATUS_TYPE { get; set; }

        public DateTime STATUS_DATE { get; set; }

        public int WEB_CALL_CHAT_USER_KEY { get; set; }

        public virtual WebCallChatSession WebCallChatSession { get; set; }

        public virtual WebCallChatUser WebCallChatUser { get; set; }
    }
}
