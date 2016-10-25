namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GlobalState
    {
        [Key]
        public int GLOBAL_STATES_KEY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE_ABBRV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_LIEN_FEE { get; set; }

        public short TL_APR_DAYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_TITLE_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_QUICK_TITLE_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_TITLE_PROC_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_NOTICE_OF_LIEN_FEE { get; set; }

        public bool ENABLE_CUST_MILITARY_STATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string STATE_FULL { get; set; }

        public bool REQUIRE_CUST_ID_SCAN { get; set; }

        public bool ENABLE_NOTIFY_REPO_COMPANY_MSG { get; set; }

        public short MIN_LOAN_AGE { get; set; }

        public bool ENABLE_SINGLE_OPEN_LOAN_TYPE { get; set; }

        public bool ENABLE_LOAN_MAINT_OTHER_STATES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TL_NO_LIEN_FEE_FOR_LOANS_UP_TO { get; set; }

        public short DUE_DATE_PAYMENTS_THREAD_COUNT { get; set; }

        public bool SHOW_ACCESS_KEY { get; set; }

        public bool ENABLE_MARKETING_INVITATIONS { get; set; }

        [Required]
        [StringLength(1)]
        public string MARKETING_INVITATION_OVERRIDES_TYPE { get; set; }

        public int MARKETING_INVITATION_INCOME_PCT { get; set; }
    }
}
