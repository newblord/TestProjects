using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ForceApprovalQuestion
    {
        public int ForceApprovalQuestionKey { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public bool IsActive { get; set; }
        public bool IsStatementRelated { get; set; }
    }
}
