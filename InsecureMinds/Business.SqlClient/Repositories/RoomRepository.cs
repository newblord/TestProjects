using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Models;
using Business.Interfaces.Repositories;
using Business.SqlClient.Models;
using Dapper;

namespace Business.SqlClient.Repositories
{
    public class RoomRepository : BaseRepository, IRoomRepository
    {
        public RoomRepository(string connectionString) : base(connectionString)
        {

        }

        public IRoom CreateRoom()
        {
            Room room = null;

            string sql = $@"INSERT INTO Room (IsClosed) Values(0)
                            SELECT Id, IsClosed from Room where Id = SCOPE_IDENTITY()";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    room = connection.Query<Room>(sql, commandType: System.Data.CommandType.Text).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return room;
        }

        public IRoom GetRoom(int id)
        {
            Room room = null;

            string sql = $@"SELECT Id, IsClosed from Room where Id = @ID";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    room = connection.Query<Room>(sql,param: new { ID = id }, commandType: System.Data.CommandType.Text).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return room;
        }
    }
}
