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
    public class HouseRuleRepository : BaseRepository, IHouseRuleRepository
    {
        public HouseRuleRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<IHouseRule> GetHouseRules()
        {
            IEnumerable<IHouseRule> rules = new List<HouseRule>();

            var sql = $@"SELECT Id, Name, Description, IsEnabled FROM HouseRule WHERE IsEnabled = 1";

            using (var connection = new SqlConnection(ConnectionString))
            {
                rules = connection.Query<HouseRule>(sql, commandType: System.Data.CommandType.Text);
            }

            return rules;
        }
    }
}
