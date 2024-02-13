using Business.Interfaces.Models;
using Business.Interfaces.Repositories;
using Business.SqlClient.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Repositories
{
    public class CardRepository : BaseRepository, ICardRepository
    {
        public CardRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<ICard> GetCards(int expansionId)
        {
            IEnumerable<ICard> cards = new List<ICard>();

            var sql = $@"SELECT Id, CardTypeId, ExpansionId, Text, PickTypeId FROM Card WHERE ExpansionId = @ID";

            using (var connection = new SqlConnection(ConnectionString))
            {
                cards = connection.Query<Card>(sql, 
                                            commandType: System.Data.CommandType.Text,
                                            param: new { ID = expansionId });
            }

            return cards;
        }

        public IEnumerable<ICard> GetCards(int[] pickTypeIds, int[] expansionPackIds)
        {
            IEnumerable<ICard> cards = new List<ICard>();

            var sql = $@"SELECT Id, CardTypeId, ExpansionId, Text, PickTypeId 
                            FROM Card 
                            WHERE PickTypeId IN (1, @PickTypeIds)
                            AND ExpansionId IN (@ExpansionPackIds)";

            var parameters = new DynamicParameters();
            parameters.Add("@PickTypeIds", string.Join(", ", pickTypeIds), System.Data.DbType.String);
            parameters.Add("@ExpansionPackIds", string.Join(", ", expansionPackIds), System.Data.DbType.String);

            using (var connection = new SqlConnection(ConnectionString))
            {
                cards = connection.Query<Card>(sql,
                                            commandType: System.Data.CommandType.Text,
                                            param: parameters);
            }

            return cards;
        }
    }
}
