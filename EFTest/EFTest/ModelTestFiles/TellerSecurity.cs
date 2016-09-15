namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerSecurity")]
    public partial class TellerSecurity
    {
        [Key]
        public int TELLER_SECURITY_KEY { get; set; }

        public int TELLER_ID_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? END_DATE { get; set; }

        public DateTime? ENDED_ON_DATE { get; set; }

        public bool IS_TEMPORARY { get; set; }

        [StringLength(256)]
        public string SG_VALUES { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual TELLERID TELLERID { get; set; }
    }
}
