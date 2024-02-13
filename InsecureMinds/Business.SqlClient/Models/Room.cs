using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class Room : Interfaces.Models.IRoom
    {
        public int Id { get; set; }

        public bool IsClosed { get; set; }
    }
}
