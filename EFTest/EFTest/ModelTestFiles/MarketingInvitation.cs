namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingInvitation")]
    public partial class MarketingInvitation
    {
        [Key]
        public int MARKETING_INVITATION_KEY { get; set; }

        public long RESERVATION_CODE { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(75)]
        public string FULL_NAME { get; set; }

        [StringLength(3)]
        public string NAME_PREFIX { get; set; }

        [Required]
        [StringLength(25)]
        public string FIRST_NAME { get; set; }

        [StringLength(10)]
        public string MIDDLE_INITIAL { get; set; }

        [Required]
        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [StringLength(3)]
        public string NAME_SUFFIX { get; set; }

        [StringLength(100)]
        public string SECONDARY_ADDRESS { get; set; }

        [Required]
        [StringLength(150)]
        public string PRIMARY_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string STREET_NUMBER { get; set; }

        [StringLength(2)]
        public string STREET_PRE_DIRECTIONAL { get; set; }

        [Required]
        [StringLength(40)]
        public string STREET_NAME { get; set; }

        [StringLength(5)]
        public string STREET_SUFFIX { get; set; }

        [StringLength(2)]
        public string STREET_POST_DIRECTIONAL { get; set; }

        [StringLength(25)]
        public string UNIT_DESIGNATOR { get; set; }

        [StringLength(25)]
        public string UNIT_NUMBER { get; set; }

        [Required]
        [StringLength(150)]
        public string CITY_STATE_ZIP_ZIP_4 { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(5)]
        public string ZIP_CODE { get; set; }

        [StringLength(4)]
        public string ZIP_4 { get; set; }

        [StringLength(4)]
        public string CARRIER_ROUTE_TYPE_WITH_NUMBER { get; set; }

        public int? DELIVERY_POINT_BARCODE { get; set; }

        [StringLength(50)]
        public string LINE_OF_TRAVEL { get; set; }

        public int? STATE_COUNTY_CODE { get; set; }

        public bool? DISASTER_ZIP_FLAG { get; set; }

        [StringLength(25)]
        public string COUNTY_NAME { get; set; }

        [StringLength(50)]
        public string KEY_CODE { get; set; }

        [StringLength(1)]
        public string MAIL_TYPE { get; set; }

        public DateTime? MAIL_DATE { get; set; }

        public DateTime EXPIRATION_DATE { get; set; }

        public decimal? APPROVED_AMOUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string IDENTIFICATION_INFO { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MINIMUM_INCOME { get; set; }
    }
}
