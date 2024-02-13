using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IRoom
    {
        int Id { get; set; }

        bool IsClosed { get; set; }
    }
}
