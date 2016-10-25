namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsuranceClaimEdit")]
    public partial class InsuranceClaimEdit
    {
        [Key]
        public int INSURANCE_CLAIM_EDIT_KEY { get; set; }

        public int INSURANCE_CLAIM_KEY { get; set; }

        public int? INSURANCE_CLAIM_STATUS_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(2000)]
        public string OLD_VALUE { get; set; }

        [Required]
        [StringLength(2000)]
        public string NEW_VALUE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual InsuranceClaim InsuranceClaim { get; set; }

        public virtual InsuranceClaimStatu InsuranceClaimStatu { get; set; }
    }
}
