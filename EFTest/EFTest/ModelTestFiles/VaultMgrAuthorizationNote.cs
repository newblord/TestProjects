namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMgrAuthorizationNote")]
    public partial class VaultMgrAuthorizationNote
    {
        [Key]
        public int VMA_NOTE_KEY { get; set; }

        public int VM_AUTH_KEY { get; set; }

        [Required]
        [StringLength(500)]
        public string NOTE { get; set; }

        public int SCORE_SUMMARY_KEY { get; set; }

        public virtual VaultMgrAuthorization VaultMgrAuthorization { get; set; }
    }
}
