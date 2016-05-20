using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal.EF
{
    public class MockDBContext : DbContext
    {
        private IDbSet<MockEntityCooperRating> _cooperRatings = new InMemoryDbSet<MockEntityCooperRating>();

        public IDbSet<MockEntityCooperRating> CooperRatings
        {
            get
            {
                return _cooperRatings;
            }
            private set
            {
            }
        }
    }

}
