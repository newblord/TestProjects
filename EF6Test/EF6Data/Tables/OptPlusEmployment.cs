namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusEmployment")]
    public partial class OptPlusEmployment
    {
        [Key]
        public int OPTPLUS_EMPLOYMENT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYER_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string WEBSITE { get; set; }

        [Required]
        [StringLength(50)]
        public string HR_CONTACT { get; set; }

        [Required]
        [StringLength(13)]
        public string HR_PHONE { get; set; }

        [Required]
        [StringLength(13)]
        public string HR_FAX { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_NUM { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_PRE_DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUFFIX { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_POST_DIR { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUITE { get; set; }

        [Required]
        [StringLength(15)]
        public string ADDR_SUITE_NUM { get; set; }

        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
