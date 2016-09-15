namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebPixelVendorData")]
    public partial class WebPixelVendorData
    {
        [Key]
        public int WPVD_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateEntered { get; set; }

        [Required]
        [StringLength(15)]
        public string IP_Address { get; set; }

        public int ScoringVendor { get; set; }

        public short? MSForResponse { get; set; }

        [Required]
        [StringLength(1)]
        public string PassWarnFail { get; set; }

        [Column(TypeName = "xml")]
        public string RawResponse { get; set; }

        [Required]
        [StringLength(500)]
        public string DEVICE_ALIAS { get; set; }

        [StringLength(250)]
        public string VendorResponseMessage { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual WebPixelVendor WebPixelVendor { get; set; }
    }
}
