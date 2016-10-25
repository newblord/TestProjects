namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RedactedWord
    {
        [Key]
        public int REDACTED_WORDS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string WORD { get; set; }
    }
}
