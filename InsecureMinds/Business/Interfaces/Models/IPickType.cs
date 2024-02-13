using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IPickType
    {
        int Id { get; set; }

        string Type { get; set; }
    }
}
