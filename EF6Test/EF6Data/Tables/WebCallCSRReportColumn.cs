namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCSRReportColumn")]
    public partial class WebCallCSRReportColumn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallCSRReportColumn()
        {
            WebCallCSRReportColumnRARRs = new HashSet<WebCallCSRReportColumnRARR>();
        }

        [Key]
        public int Web_Call_CSRReport_Columns_Key { get; set; }

        [Required]
        [StringLength(200)]
        public string ColumnName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallCSRReportColumnRARR> WebCallCSRReportColumnRARRs { get; set; }
    }
}
