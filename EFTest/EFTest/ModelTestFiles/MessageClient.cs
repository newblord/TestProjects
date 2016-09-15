namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageClient")]
    public partial class MessageClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageClient()
        {
            Messages = new HashSet<Message>();
        }

        [Key]
        public int MESSAGE_CLIENT_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string MESSAGE_CLIENT_NAME { get; set; }

        [StringLength(250)]
        public string MESSAGE_CLIENT_DESCRIPTION { get; set; }

        public int MESSAGE_CLIENT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
