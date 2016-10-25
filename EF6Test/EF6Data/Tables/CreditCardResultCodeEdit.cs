namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardResultCodeEdit")]
    public partial class CreditCardResultCodeEdit
    {
        [Key]
        [Column(Order = 0)]
        public int CCRC_Edit_Key { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Credit_Card_Result_Code_Key { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Field_Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Old_Value { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string New_Value { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string Teller { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Last_Modified_By { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime Last_Modified_Date { get; set; }
    }
}
