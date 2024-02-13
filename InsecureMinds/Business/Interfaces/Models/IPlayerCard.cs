using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IPlayerCard
    {
        int Id { get; set; }

        int PlayerId { get; set; }

        int RoomCardId { get; set; }

        int IsUsed { get; set; }

        int IsDiscarded { get; set; }
    }
}
