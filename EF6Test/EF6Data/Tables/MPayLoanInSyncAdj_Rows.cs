namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MPayLoanInSyncAdj_Rows
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(35)]
        public string FIELD_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string PRV_VAL { get; set; }

        [Required]
        [StringLength(25)]
        public string CHG_TO_VAL { get; set; }
    }
}
