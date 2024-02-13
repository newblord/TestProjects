using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BaseRepository
    {
        public string ConnectionString { get; }

        public BaseRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
