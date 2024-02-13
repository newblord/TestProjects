using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IRoomCard
    {
        int Id { get; set; }

        int RoomId { get; set; }

        int CardId { get; set; }

        bool IsDealt { get; set; }

        bool IsDiscarded { get; set; }
    }
}
