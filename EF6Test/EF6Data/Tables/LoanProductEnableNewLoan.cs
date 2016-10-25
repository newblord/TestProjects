namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductEnableNewLoan")]
    public partial class LoanProductEnableNewLoan
    {
        [Key]
        public int LOAN_PRODUCT_ENABLE_NEW_LOAN_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int LOAN_PRODUCT_TILA_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime END_DATE { get; set; }

        public bool ENABLE_AGREEMENT_NUMBER { get; set; }

        public int NEXT_AGREEMENT_NUMBER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public short? LIEN_ADDRESS_LOCATION { get; set; }

        public byte? HOTKEY_NUMBER { get; set; }

        public byte? DISPLAY_ORDER { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }

        public virtual LoanProductTila LoanProductTila { get; set; }
    }
}
