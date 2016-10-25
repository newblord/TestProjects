namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallChatSession")]
    public partial class WebCallChatSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallChatSession()
        {
            WebCallChatMessages = new HashSet<WebCallChatMessage>();
            WebCallChatStatus = new HashSet<WebCallChatStatu>();
        }

        [Key]
        public Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        public int WEB_CALL_CHAT_USER_KEY { get; set; }

        public DateTime? DATE_REQUESTED { get; set; }

        public DateTime? DATE_ACCEPTED { get; set; }

        public DateTime? DATE_ENDED { get; set; }

        public int WEB_CALL_CHAT_TOPICS_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallChatMessage> WebCallChatMessages { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallChatStatu> WebCallChatStatus { get; set; }
    }
}
