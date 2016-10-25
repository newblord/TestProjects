namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_DocuwareInfoByTransDetailKey
    {
        [StringLength(40)]
        public string CUSTNAME { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [StringLength(20)]
        public string DRIVERSLIC { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STORE_NO { get; set; }

        [StringLength(10)]
        public string DOCDATE { get; set; }

        public int? CUSTOMER_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }
    }
}
