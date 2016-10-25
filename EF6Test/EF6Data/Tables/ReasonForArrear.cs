namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReasonForArrear
    {
        [Key]
        public int REASON_FOR_ARREARS_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_UPDATED { get; set; }

        public int UPDATED_TELLER_ID_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual TELLERID TELLERID { get; set; }
    }
}
