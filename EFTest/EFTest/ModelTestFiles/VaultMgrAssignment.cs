namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMgrAssignment")]
    public partial class VaultMgrAssignment
    {
        [Key]
        public int VM_ASSIGN_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string LOGGED_ON_INITS { get; set; }

        [Required]
        [StringLength(3)]
        public string CURRENT_VM_INITS { get; set; }

        [Required]
        [StringLength(3)]
        public string NEW_VM_INITS { get; set; }

        [StringLength(3)]
        public string OTHER_AUTH_INITS { get; set; }

        public DateTime TIME_ASSIGNED { get; set; }

        public virtual Company Company { get; set; }
    }
}
