using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallAuthorizedVisitorContact
    {
        public int WebCallAuthorizedVisitorContactKey { get; set; }
        public int VisitorKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
