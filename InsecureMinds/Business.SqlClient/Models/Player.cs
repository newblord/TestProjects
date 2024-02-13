using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class Player : Interfaces.Models.IPlayer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string IPAddress { get; set; }

        public bool IsActive { get; set; }
    }
}
