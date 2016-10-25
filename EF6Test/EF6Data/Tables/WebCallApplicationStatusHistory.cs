namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallApplicationStatusHistory")]
    public partial class WebCallApplicationStatusHistory
    {
        [Key]
        public int Web_Call_Application_Status_History_KEY { get; set; }

        public int Loan_Application_Key { get; set; }

        public int Web_Call_RARR_History_Key { get; set; }

        public int Loan_Application_Status { get; set; }

        public DateTime? Application_Status_Change_Date { get; set; }

        public DateTime CREATEDATE { get; set; }
    }
}
