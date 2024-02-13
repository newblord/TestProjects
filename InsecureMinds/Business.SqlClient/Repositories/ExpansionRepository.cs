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
    public class ExpansionRepository : BaseRepository, IExpansionRepository
    {
        public ExpansionRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<IExpansion> GetExpansions()
        {
            IEnumerable<IExpansion> expansions = new List<IExpansion>();
            
            var sql = $@"SELECT Id, Name, Description, IsRequired FROM Expansion";

            using (var connection = new SqlConnection(ConnectionString))
            {
                expansions = connection.Query<Expansion>(sql, commandType: System.Data.CommandType.Text);
            }

            return expansions;
        }

        public IExpansion GetExpansion(int id)
        {
            IExpansion expansion = new Expansion();

            var sql = $@"SELECT Id, Name, Description, IsRequired FROM Expansion WHERE Id = @ID";

            var parameters = new { ID = id };

            using (var connection = new SqlConnection(ConnectionString))
            {
                expansion = connection.QueryFirst<Expansion>(sql, commandType: System.Data.CommandType.Text, param: parameters);
            }

            return expansion;
        }
    }
}
