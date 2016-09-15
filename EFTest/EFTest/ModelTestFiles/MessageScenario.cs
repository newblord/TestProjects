namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageScenario")]
    public partial class MessageScenario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageScenario()
        {
            Messages = new HashSet<Message>();
        }

        [Key]
        public int MESSAGE_SCENARIO_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string MESSAGE_SCENARIO_NAME { get; set; }

        [StringLength(250)]
        public string MESSAGE_SCENARIO_DESCRIPTION { get; set; }

        public int MESSAGE_SCENARIO_ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
