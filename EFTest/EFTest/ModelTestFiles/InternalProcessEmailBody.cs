namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InternalProcessEmailBody")]
    public partial class InternalProcessEmailBody
    {
        [Key]
        [Column(Order = 0)]
        public int INTERNAL_PROCESS_EMAIL_BODY_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INTERNAL_PROCESS_EMAIL_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string BODY { get; set; }

        public virtual InternalProcessEmail InternalProcessEmail { get; set; }
    }
}
