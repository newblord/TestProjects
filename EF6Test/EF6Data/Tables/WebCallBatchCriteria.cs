namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallBatchCriteria")]
    public partial class WebCallBatchCriteria
    {
        [Key]
        public int Web_Call_BatchTaskCriteria_Key { get; set; }

        public int Web_Call_BatchTask_Key { get; set; }

        public int Criteria_Type { get; set; }

        public int Criteria_Value { get; set; }

        public int? Web_Call_Reason_Key { get; set; }

        public int? Web_Call_Action_Key { get; set; }

        public int? Web_Call_Result1_Key { get; set; }

        public int? Web_Call_Result2_Key { get; set; }

        public int? Web_Call_Rarr_Key { get; set; }

        public virtual WebCallBatchTask WebCallBatchTask { get; set; }
    }
}
