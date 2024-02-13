using Business.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Repositories
{
    public interface IExpansionRepository
    {
        IEnumerable<IExpansion> GetExpansions();

        IExpansion GetExpansion(int id);
    }
}
