using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorSecurityQuestion
    {
        public VisitorSecurityQuestion()
        {
            Visitor = new HashSet<Visitor>();
        }

        public int VisitorSecurityQuestionKey { get; set; }
        public string Question { get; set; }
        public byte DisplayOrder { get; set; }

        public virtual ICollection<Visitor> Visitor { get; set; }
    }
}
