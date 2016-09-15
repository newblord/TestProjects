namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebReferralMethod")]
    public partial class WebReferralMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WEB_REFERRAL_METHOD_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public bool IS_ACTIVE { get; set; }

        public int SORT_ORDER { get; set; }
    }
}
