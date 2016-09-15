namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallChatCannedResponses")]
    public partial class WebCallChatCannedRespons
    {
        [Key]
        public int WEB_CALL_CHAT_CANNED_RESPONSES_KEY { get; set; }

        [Required]
        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        public short SORT_PRIORITY { get; set; }

        public bool DELETED { get; set; }
    }
}
