namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDIACHHistory")]
    public partial class DDIACHHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DDI_KEY { get; set; }

        public int ACH_HISTORY_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ACH_SEQUENCE_NUMBER { get; set; }

        public virtual ACH_History ACH_History { get; set; }

        public virtual DDI DDI { get; set; }
    }
}
