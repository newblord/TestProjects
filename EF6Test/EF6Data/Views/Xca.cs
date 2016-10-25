namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xca")]
    public partial class Xca
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cakey { get; set; }

        public int? ckey { get; set; }

        [StringLength(25)]
        public string LASTNAME { get; set; }

        [StringLength(24)]
        public string FIRSTNAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string X { get; set; }

        [StringLength(500)]
        public string Spell_ADDRESS_SOURCE_CODE { get; set; }

        [StringLength(250)]
        public string Spell_ADDRESS_STATUS_CODE { get; set; }

        [StringLength(100)]
        public string Spell_ADDRESS_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string Spell_ADDR_SUFFIX { get; set; }

        [StringLength(150)]
        public string Spell_ADDR_SUITE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Z { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_ADDRESS_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte ADDRESS_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte ADDRESS_SOURCE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte ADDRESS_STATUS_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ADDRESS_PRIORITY { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string ADDRESS_CONTACT_LAST_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string ADDRESS_CONTACT_FIRST_NAME { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string CITY { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string STATE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_LAST_USED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? STATUS_CHANGE_DATE { get; set; }

        [StringLength(3)]
        public string STATUS_CHANGE_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRIORITY_CHANGE_DATE { get; set; }

        [StringLength(3)]
        public string PRIORITY_CHANGE_TELLER { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(10)]
        public string ADDR_NUM { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(2)]
        public string ADDR_PRE_DIR { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(10)]
        public string ADDR_SUFFIX { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(2)]
        public string ADDR_POST_DIR { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(10)]
        public string ADDR_SUITE { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(15)]
        public string ADDR_SUITE_NUM { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime LAST_UPDATED { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FROM_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TO_DATE { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        public byte? REMOVED_REASON_KEY { get; set; }

        [StringLength(2000)]
        public string REMOVED_REASON_NOTES { get; set; }
    }
}
