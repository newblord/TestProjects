namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InternalProcessEmailType")]
    public partial class InternalProcessEmailType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte INTERNAL_PROCESS_EMAIL_TYPE_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string INTERNAL_PROCESS_EMAIL_TYPE { get; set; }
    }
}
