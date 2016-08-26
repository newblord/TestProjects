namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdnMatch")]
    public partial class SdnMatch
    {
        [Key]
        public int SDN_MATCH_KEY { get; set; }

        [StringLength(350)]
        public string SDN_NAME { get; set; }

        [StringLength(16)]
        public string SDN_TYPE { get; set; }

        [StringLength(75)]
        public string SDN_PROGRAM { get; set; }

        [StringLength(200)]
        public string SDN_TITLE { get; set; }

        [StringLength(1500)]
        public string SDN_REMARKS { get; set; }

        [StringLength(8)]
        public string ALT_TYPE { get; set; }

        [StringLength(350)]
        public string ALT_NAME { get; set; }

        [StringLength(750)]
        public string ADD_ADDRESS { get; set; }

        [StringLength(75)]
        public string ADD_CITY { get; set; }

        [StringLength(250)]
        public string ADD_COUNTRY { get; set; }

        [StringLength(200)]
        public string ADD_REMARKS { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? SDN_CERT_KEY { get; set; }
    }
}
