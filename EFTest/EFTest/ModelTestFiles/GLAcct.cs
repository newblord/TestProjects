namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GLAcct")]
    public partial class GLAcct
    {
        [Key]
        public int GL_ACCT_KEY { get; set; }

        public int GL_ACCT_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public bool IS_ADASTRA { get; set; }

        public bool IS_TITLE_ACCT { get; set; }

        public bool IS_NONCASH_ACCT { get; set; }

        public bool IS_TRECS_CASH_ACCT { get; set; }
    }
}
