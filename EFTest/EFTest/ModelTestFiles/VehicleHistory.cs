namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleHistory")]
    public partial class VehicleHistory
    {
        [Key]
        public int VEHICLE_HISTORY_KEY { get; set; }

        public int VEHICLE_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VEH_WHOLESALE { get; set; }

        public int VEH_MILEAGE { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_CONDITION { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_VER_EST { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
