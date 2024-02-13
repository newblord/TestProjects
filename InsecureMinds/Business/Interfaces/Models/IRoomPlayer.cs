using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IRoomPlayer
    {
        int Id { get; set; }

        int RoomId { get; set; }

        int PlayerId { get; set; }
    }
}
