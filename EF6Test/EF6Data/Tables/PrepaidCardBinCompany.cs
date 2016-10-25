namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardBinCompany")]
    public partial class PrepaidCardBinCompany
    {
        [Key]
        public int PREPAID_CARD_BIN_COMPANY_KEY { get; set; }

        public int PREPAID_CARD_BIN_KEY { get; set; }

        public short LOCATION { get; set; }

        public int? PREPAID_CARD_GROUP_KEY { get; set; }

        public bool? ALLOW_ASSIGN_CARDS { get; set; }

        public bool? ALLOW_LOADS { get; set; }

        public bool? ALLOW_UNLOADS { get; set; }

        public bool? ALLOW_LOST_STOLEN { get; set; }

        public bool? ALLOW_CHANGE_PRODUCT { get; set; }

        public bool? ALLOW_DIRECT_DEPOSIT { get; set; }

        [StringLength(30)]
        public string VENDOR_UAT_CLIENTID { get; set; }

        [StringLength(30)]
        public string VENDOR_PROD_CLIENTID { get; set; }

        public virtual Company Company { get; set; }

        public virtual PrepaidCardBin PrepaidCardBin { get; set; }

        public virtual PrepaidCardGroup PrepaidCardGroup { get; set; }
    }
}
