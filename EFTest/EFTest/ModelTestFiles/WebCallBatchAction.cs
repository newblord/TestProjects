namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallBatchAction")]
    public partial class WebCallBatchAction
    {
        [Key]
        public int Web_Call_BatchTaskAction_Key { get; set; }

        public int Web_Call_BatchTask_Key { get; set; }

        public int Action_Type { get; set; }

        public int? Web_Call_Reason_Key { get; set; }

        public int? Web_Call_Action_Key { get; set; }

        public int? Web_Call_Result1_Key { get; set; }

        public int? Web_Call_Result2_Key { get; set; }

        public int? Web_Call_Rarr_Key { get; set; }

        public int? Web_Call_Category_Key { get; set; }

        public virtual WebCallBatchTask WebCallBatchTask { get; set; }
    }
}
