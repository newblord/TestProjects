using Business.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Repositories
{
    public interface IRoomCardRepository
    {
        void CreateRoomCards(IRoom room, List<ICard> blackCards, List<ICard> whiteCards);
    }
}
