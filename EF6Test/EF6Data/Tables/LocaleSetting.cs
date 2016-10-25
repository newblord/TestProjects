namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaleSetting")]
    public partial class LocaleSetting
    {
        [Key]
        public int LOCALE_SETTING_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string CURRENCY_SYMBOL { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONE_FORMAT { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIP_FORMAT { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        public byte DEBIT_CARD_MAX_LEN { get; set; }

        [Required]
        [StringLength(3)]
        public string SSN_OR_NIN { get; set; }

        public bool SHOW_ITEM { get; set; }

        public bool ENABLE_VERIFY_BANK { get; set; }

        public bool ENABLE_KBB { get; set; }

        public bool ENABLE_IAT { get; set; }

        public bool ENABLE_HPI { get; set; }
    }
}
