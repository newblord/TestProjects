namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterProduct")]
    public partial class FormLetterProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string LOAN_SUB_TYPE { get; set; }

        public virtual FormLetter FormLetter { get; set; }
    }
}
