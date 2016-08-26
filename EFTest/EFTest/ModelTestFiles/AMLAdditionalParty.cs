namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AMLAdditionalParty")]
    public partial class AMLAdditionalParty
    {
        [Key]
        public int AML_ADDITIONAL_PARTY_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(50)]
        public string ENTITY_NAME { get; set; }

        [StringLength(25)]
        public string FIRST_NAME { get; set; }

        [StringLength(1)]
        public string MID_INITIAL { get; set; }

        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [StringLength(12)]
        public string PHONE_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public int? AML_OCCUPATION_KEY { get; set; }

        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [StringLength(10)]
        public string ADDR_NUM { get; set; }

        [StringLength(2)]
        public string ADDR_PRE_DIR { get; set; }

        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [StringLength(10)]
        public string ADDR_SUFFIX { get; set; }

        [StringLength(2)]
        public string ADDR_POST_DIR { get; set; }

        [StringLength(10)]
        public string ADDR_SUITE { get; set; }

        [StringLength(15)]
        public string ADDR_SUITE_NUM { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(2)]
        public string STATE { get; set; }

        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [StringLength(25)]
        public string COUNTY { get; set; }

        [StringLength(3)]
        public string COUNTRY { get; set; }

        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [StringLength(1)]
        public string ID_TYPE { get; set; }

        [StringLength(40)]
        public string ID_NUMBER { get; set; }

        [StringLength(2)]
        public string ID_STATE { get; set; }

        public int? COUNTRY_KEY { get; set; }

        [StringLength(20)]
        public string TAX_ID { get; set; }

        [StringLength(30)]
        public string PURPOSE { get; set; }

        [StringLength(20)]
        public string RELATIONSHIP { get; set; }

        public bool IS_ENTITY { get; set; }

        public bool IS_REGISTERED_CHARITY { get; set; }

        [StringLength(20)]
        public string INCORPORATION_NUMBER { get; set; }

        [StringLength(20)]
        public string INCORPORATION_PLACE { get; set; }

        [StringLength(20)]
        public string BUSINESS_TYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        public virtual AMLOccupation AMLOccupation { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
