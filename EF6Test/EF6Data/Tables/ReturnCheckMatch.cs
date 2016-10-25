namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnCheckMatch")]
    public partial class ReturnCheckMatch
    {
        [Key]
        public int RETURN_CHECK_MATCH_KEY { get; set; }

        public int RETURN_CHECK_DETAIL_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public virtual ReturnCheckDetail ReturnCheckDetail { get; set; }
    }
}
