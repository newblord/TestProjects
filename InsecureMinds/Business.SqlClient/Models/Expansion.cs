using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class Expansion : Interfaces.Models.IExpansion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsRequired { get; set; }

        public bool IsEnabled { get; set; }
    }
}
