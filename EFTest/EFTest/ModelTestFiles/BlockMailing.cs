namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlockMailing")]
    public partial class BlockMailing
    {
        [Key]
        public int BLOCK_MAILING_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
