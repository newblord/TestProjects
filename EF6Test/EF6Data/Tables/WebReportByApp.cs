namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebReportByApp")]
    public partial class WebReportByApp
    {
        [Key]
        public int Web_Report_By_App_Key { get; set; }

        public int loan_application_key { get; set; }

        public DateTime date_reported { get; set; }

        public int customer_key { get; set; }

        public int loan_key { get; set; }

        [StringLength(50)]
        public string source_app_description { get; set; }

        [StringLength(5)]
        public string zipcode { get; set; }

        [StringLength(4)]
        public string msa { get; set; }

        [StringLength(2)]
        public string def_state { get; set; }

        public int location { get; set; }

        public bool? is_new_customer { get; set; }

        public bool? is_app_complete { get; set; }

        public bool? is_app_approved { get; set; }

        public bool? is_app_force_approved { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? net_income { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? approved_amt { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? princ_amt { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? fee_amt { get; set; }

        [StringLength(50)]
        public string web_referral_method { get; set; }

        [StringLength(500)]
        public string source { get; set; }
    }
}
