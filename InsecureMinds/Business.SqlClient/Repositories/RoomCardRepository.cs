using Business.Interfaces.Models;
using Business.Interfaces.Repositories;
using Business.SqlClient.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace Business.SqlClient.Repositories
{
    public class RoomCardRepository : BaseRepository, IRoomCardRepository
    {
        public RoomCardRepository(string connectionString) : base(connectionString)
        {

        }

        public void CreateRoomCards(IRoom room, List<ICard> blackCards, List<ICard> whiteCards)
        {
            DapperPlusManager.Entity<RoomCard>().Table("RoomCard");

            var cards = new List<RoomCard>();

            for(int i = 0; i < blackCards.Count; i++)
            {
                cards.Add(new RoomCard()
                {
                    CardId = blackCards[i].Id,
                    IsDealt = false,
                    IsDiscarded = false,
                    RoomId = room.Id
                });
            }

            for (int x = 0; x < whiteCards.Count; x++)
            {
                cards.Add(new RoomCard()
                {
                    CardId = blackCards[x].Id,
                    IsDealt = false,
                    IsDiscarded = false,
                    RoomId = room.Id
                });
            }

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.BulkInsert(cards);
            }
        }
    }
}
