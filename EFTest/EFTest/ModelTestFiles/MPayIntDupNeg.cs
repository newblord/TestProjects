namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayIntDupNeg")]
    public partial class MPayIntDupNeg
    {
        [Key]
        public int MPAY_INTEREST_KEY { get; set; }
    }
}
