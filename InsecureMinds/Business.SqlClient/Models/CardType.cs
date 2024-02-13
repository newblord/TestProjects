using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class CardType : Interfaces.Models.ICardType
    {
        public int Id { get; set; }

        public string Type { get; set; }
    }
}
