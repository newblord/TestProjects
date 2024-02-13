using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface ICardType
    {
        int Id { get; set; }

        string Type { get; set; }
    }
}
