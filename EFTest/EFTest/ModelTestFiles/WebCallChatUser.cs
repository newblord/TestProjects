namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallChatUser")]
    public partial class WebCallChatUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallChatUser()
        {
            WebCallChatStatus = new HashSet<WebCallChatStatu>();
        }

        [Key]
        public int WEB_CALL_CHAT_USER_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string PHONE_NUMBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallChatStatu> WebCallChatStatus { get; set; }
    }
}
