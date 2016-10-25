namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MPayIntDupPos
    {
        [Key]
        public int MPAY_INTEREST_KEY { get; set; }
    }
}
