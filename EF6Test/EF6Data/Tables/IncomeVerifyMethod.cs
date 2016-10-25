namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeVerifyMethod")]
    public partial class IncomeVerifyMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomeVerifyMethod()
        {
            CustomerIncomes = new HashSet<CustomerIncome>();
            IncomeVerifyMethodLocations = new HashSet<IncomeVerifyMethodLocation>();
        }

        [Key]
        public int INCOME_VERIFY_METHOD_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string VERIFY_TYPE { get; set; }

        [Required]
        [StringLength(40)]
        public string VERIFY_METHOD { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool VALIDATES_STEADY_INCOME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LAST_UPDATED_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerIncome> CustomerIncomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomeVerifyMethodLocation> IncomeVerifyMethodLocations { get; set; }
    }
}
