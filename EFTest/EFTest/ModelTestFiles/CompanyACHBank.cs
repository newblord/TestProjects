namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyACHBank")]
    public partial class CompanyACHBank
    {
        [Key]
        public int CompanyACHBank_Key { get; set; }

        public short LOCATION { get; set; }

        public int? CREDIT_ACH_BANK_KEY { get; set; }

        public int? DEBIT_ACH_BANK_KEY { get; set; }

        public virtual ACHBank ACHBank { get; set; }

        public virtual ACHBank ACHBank1 { get; set; }
    }
}
