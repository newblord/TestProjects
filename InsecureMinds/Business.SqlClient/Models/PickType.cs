using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class PickType : Interfaces.Models.IPickType
    {
        public int Id { get; set; }

        public string Type { get; set; }
    }
}
