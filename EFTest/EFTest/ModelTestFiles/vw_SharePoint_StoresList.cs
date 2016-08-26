namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_SharePoint_StoresList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string COMPANY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ADDRESS1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string CITY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string STATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [StringLength(4000)]
        public string PHONE { get; set; }

        [StringLength(4000)]
        public string FAX { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string STORE_HOURS { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(300)]
        public string STORE_EMAIL_ADDRESS { get; set; }
    }
}
