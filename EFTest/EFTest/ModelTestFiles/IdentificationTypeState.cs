namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentificationTypeState")]
    public partial class IdentificationTypeState
    {
        [Key]
        public int IDENTIFICATION_TYPE_STATE_KEY { get; set; }

        public int IDENTIFICATION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(2)]
        public string ID_STATE { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public bool STORE_EXPIRATION_REQUIRED { get; set; }

        public bool STORE_ACCEPTABLE_FOR_NEW_LOAN { get; set; }

        public bool WEB_ACCEPTABLE_FOR_NEW_LOAN { get; set; }

        public bool WEB_EXPIRATION_REQUIRED { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }
    }
}
