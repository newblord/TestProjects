namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doc10000TransDetail
    {
        [Key]
        public int DOC_10000_TRANS_DETAIL_KEY { get; set; }

        public int DOC_10000_TRANS_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public virtual Doc10000Trans Doc10000Trans { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
