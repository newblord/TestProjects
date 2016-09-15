namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingInvitationHistory")]
    public partial class MarketingInvitationHistory
    {
        [Key]
        public int MARKETING_INVITATION_HISTORY_KEY { get; set; }

        public long RESERVATION_CODE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int ATTRIBUTES { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }
    }
}
