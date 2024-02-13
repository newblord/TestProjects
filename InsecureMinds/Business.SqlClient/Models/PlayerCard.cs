using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class PlayerCard : Interfaces.Models.IPlayerCard
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public int RoomCardId { get; set; }

        public int IsUsed { get; set; }

        public int IsDiscarded { get; set; }
    }
}
