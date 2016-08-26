namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaleTranslator")]
    public partial class LocaleTranslator
    {
        [Key]
        public int LOCALE_TRANSLATOR_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY_CODE { get; set; }

        [Required]
        [StringLength(75)]
        public string ENGLISH_VALUE { get; set; }

        [Required]
        [StringLength(75)]
        public string LOCALE_VALUE { get; set; }

        public bool EXACT_MATCH_ONLY { get; set; }
    }
}
