using Business.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Repositories
{
    public interface ICardRepository
    {
        IEnumerable<ICard> GetCards(int expansionId);

        IEnumerable<ICard> GetCards(int[] pickTypeIds, int[] expansionPackIds);
    }
}
