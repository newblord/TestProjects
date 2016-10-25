namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AACbExportDataArchive")]
    public partial class AACbExportDataArchive
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountType { get; set; }

        [StringLength(2)]
        public string AccountStatus { get; set; }

        [StringLength(8)]
        public string DateOfLoss { get; set; }

        [StringLength(8)]
        public string InputDate { get; set; }

        [StringLength(25)]
        public string Creditor { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditorClassification { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ECOA { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string PortfolioType { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal AmountPastDue { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smallmoney")]
        public decimal AmountDue { get; set; }

        [Column(TypeName = "money")]
        public decimal? HighestCredit { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(8)]
        public string LastPaymentDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string TermsDuration { get; set; }

        [StringLength(2)]
        public string ComplianceConditionCode { get; set; }

        [StringLength(24)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string MiddleName { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }

        [StringLength(1)]
        public string GenerationCode { get; set; }

        [StringLength(150)]
        public string Street1 { get; set; }

        public int? Street2 { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string City { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string State { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string Zip { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(12)]
        public string Telephone { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [StringLength(8)]
        public string DOB { get; set; }

        [StringLength(8)]
        public string DateClosed { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime EXPORT_DATE { get; set; }

        [StringLength(1)]
        public string CII { get; set; }
    }
}
