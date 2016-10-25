namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RiUrgentNote")]
    public partial class RiUrgentNote
    {
        [Key]
        public int RI_URGENT_NOTE_KEY { get; set; }

        [Required]
        public string URGENT_NOTE_TEXT { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        public int TELLER_ID_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual TELLERID TELLERID { get; set; }
    }
}
