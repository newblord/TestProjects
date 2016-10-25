namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckReturn")]
    public partial class CheckReturn
    {
        [Key]
        public int CHECK_RETURN_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int CR_GL_ACCT { get; set; }

        public byte CR_REASON_CODE { get; set; }
    }
}
