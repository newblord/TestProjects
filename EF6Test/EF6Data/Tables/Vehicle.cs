namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            TitleLoans = new HashSet<TitleLoan>();
            VehicleHistories = new HashSet<VehicleHistory>();
        }

        [Key]
        public int VEHICLE_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_VIN { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_MAKE { get; set; }

        [StringLength(100)]
        public string VEH_MODEL { get; set; }

        [StringLength(100)]
        public string VEH_BODY { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_ENGINE { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_TRANS { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_DRIVE { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_MISC_EQUIP1 { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_MISC_EQUIP2 { get; set; }

        [Required]
        [StringLength(40)]
        public string VEH_MISC_EQUIP3 { get; set; }

        public short VEH_YEAR { get; set; }

        [Column(TypeName = "money")]
        public decimal LIST_PRICE { get; set; }

        [Required]
        [StringLength(20)]
        public string VEH_COLOR { get; set; }

        [Required]
        [StringLength(1)]
        public string FUEL_TYPE { get; set; }

        [Required]
        [StringLength(10)]
        public string PLATE { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleLoan> TitleLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleHistory> VehicleHistories { get; set; }
    }
}
