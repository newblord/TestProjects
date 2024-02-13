using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class RoomPlayer : Interfaces.Models.IRoomPlayer
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public int PlayerId { get; set; }
    }
}
