namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        [Key]
        public int MESSAGE_KEY { get; set; }

        public int MESSAGE_CLASS_KEY { get; set; }

        public int MESSAGE_SCENARIO_KEY { get; set; }

        public int MESSAGE_CLIENT_KEY { get; set; }

        [Required]
        public string MESSAGE_TEXT { get; set; }

        [StringLength(50)]
        public string MESSAGE_DIRECTIVE { get; set; }

        public virtual MessageClass MessageClass { get; set; }

        public virtual MessageClient MessageClient { get; set; }

        public virtual MessageScenario MessageScenario { get; set; }
    }
}
