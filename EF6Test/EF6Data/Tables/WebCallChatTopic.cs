namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallChatTopic
    {
        [Key]
        public int WEB_CALL_CHAT_TOPICS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public short SORT_PRIORITY { get; set; }

        public bool DELETED { get; set; }
    }
}
