using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IPlayer
    {
        int Id { get; set; }

        string Name { get; set; }

        string IPAddress { get; set; }

        bool IsActive { get; set; }
    }
}
