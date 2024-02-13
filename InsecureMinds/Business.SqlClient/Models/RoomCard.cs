using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class RoomCard : Interfaces.Models.IRoomCard
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public int CardId { get; set; }

        public bool IsDealt { get; set; }

        public bool IsDiscarded { get; set; }
    }
}
