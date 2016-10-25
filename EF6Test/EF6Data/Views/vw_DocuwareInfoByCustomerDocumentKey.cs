namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_DocuwareInfoByCustomerDocumentKey
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_DOCUMENT_KEY { get; set; }

        [StringLength(9)]
        public string SOCIALSECURITYNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STORENO { get; set; }

        [StringLength(20)]
        public string DRIVERSLICENSE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMERNO { get; set; }

        [StringLength(24)]
        public string FIRST_NAME { get; set; }

        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [StringLength(10)]
        public string DOCUMENTDATE { get; set; }

        [StringLength(100)]
        public string DOC_TYPE { get; set; }
    }
}
