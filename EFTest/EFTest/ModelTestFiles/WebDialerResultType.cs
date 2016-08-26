namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerResultType")]
    public partial class WebDialerResultType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebDialerResultType()
        {
            WebCallRARRs = new HashSet<WebCallRARR>();
            WebDialerResults = new HashSet<WebDialerResult>();
        }

        public int IATResultTypeKey { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRIPTION { get; set; }

        public bool DELETED { get; set; }

        [StringLength(150)]
        public string FIVE_NINE_KEY { get; set; }

        public int? WEB_CALL_CATRARR_ALIAS_KEY { get; set; }

        public bool? IS_SYSTEM_DISPOSITION { get; set; }

        [Key]
        public int WEB_DIALER_RESULT_TYPE_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallRARR> WebCallRARRs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebDialerResult> WebDialerResults { get; set; }
    }
}
