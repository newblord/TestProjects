namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageClass")]
    public partial class MessageClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageClass()
        {
            Messages = new HashSet<Message>();
        }

        [Key]
        public int MESSAGE_CLASS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string MESSAGE_CLASS_NAME { get; set; }

        [StringLength(250)]
        public string MESSAGE_CLASS_DESCRIPTION { get; set; }

        public int MESSAGE_CLASS_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
