using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrescreenQuestion
    {
        public PrescreenQuestion()
        {
            PrescreenQuestionState = new HashSet<PrescreenQuestionState>();
        }

        public int PrescreenQuestionKey { get; set; }
        public int PrescreenQuestionTypeKey { get; set; }
        public string MainText { get; set; }
        public bool ValidResponse { get; set; }
        public short SortOrder { get; set; }
        public int? Color { get; set; }
        public string DetailText { get; set; }
        public string ValidationMessage { get; set; }
        public int? ValidationMessageColor { get; set; }
        public bool IsActive { get; set; }
        public string QuestionName { get; set; }

        public virtual ICollection<PrescreenQuestionState> PrescreenQuestionState { get; set; }
        public virtual PrescreenQuestionType PrescreenQuestionTypeKeyNavigation { get; set; }
    }
}
