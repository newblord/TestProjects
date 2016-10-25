namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocuwareLoanLkup")]
    public partial class DocuwareLoanLkup
    {
        [Key]
        public int DOCUWARE_LOAN_LKUP_KEY { get; set; }

        public int DOCUWARE_CABINET_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int DWDOCID { get; set; }

        public virtual DocuwareCabinet DocuwareCabinet { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
