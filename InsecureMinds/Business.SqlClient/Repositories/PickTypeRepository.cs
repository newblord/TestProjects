using Business.Interfaces.Models;
using Business.Interfaces.Repositories;
using Business.SqlClient.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Repositories
{
    public class PickTypeRepository : BaseRepository, IPickTypeRepository
    {
        public PickTypeRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<IPickType> GetPickTypes()
        {
            IEnumerable<IPickType> pickTypes = new List<PickType>();

            var sql = $@"SELECT Id, Type FROM PickType";

            using(var connection = new SqlConnection(ConnectionString))
            {
                pickTypes = connection.Query<PickType>(sql, commandType: System.Data.CommandType.Text);
            }

            return pickTypes;
        }
    }
}
