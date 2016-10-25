namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESignOptIn")]
    public partial class ESignOptIn
    {
        [Key]
        public int ESIGN_OPT_IN_KEY { get; set; }

        public int ESIGN_OPT_IN_DOC_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short LOCATION { get; set; }
    }
}
