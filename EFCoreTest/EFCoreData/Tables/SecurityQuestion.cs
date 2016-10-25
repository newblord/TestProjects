using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SecurityQuestion
    {
        public SecurityQuestion()
        {
            SecurityAnswer = new HashSet<SecurityAnswer>();
        }

        public int SecurityQuestionKey { get; set; }
        public string Question { get; set; }
        public DateTime DateEntered { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SecurityAnswer> SecurityAnswer { get; set; }
    }
}
