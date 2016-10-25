namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DualApprovalMessage")]
    public partial class DualApprovalMessage
    {
        [Key]
        public int DUAL_APPROVAL_MESSAGE_KEY { get; set; }

        [Required]
        [StringLength(8000)]
        public string APPROVAL_MESSAGE { get; set; }

        public int MESSAGE_ID { get; set; }
    }
}
