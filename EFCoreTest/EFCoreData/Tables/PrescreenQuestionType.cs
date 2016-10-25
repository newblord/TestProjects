using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrescreenQuestionType
    {
        public PrescreenQuestionType()
        {
            PrescreenQuestion = new HashSet<PrescreenQuestion>();
        }

        public int PrescreenQuestionTypeKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PrescreenQuestion> PrescreenQuestion { get; set; }
    }
}
