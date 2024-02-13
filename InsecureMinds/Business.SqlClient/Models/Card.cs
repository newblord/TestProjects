using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SqlClient.Models
{
    public class Card : Interfaces.Models.ICard
    {
        public int Id { get; set; }

        public Enums.CardType CardTypeId { get; set; }

        public int ExpansionId { get; set; }

        public string Text { get; set; }

        public Enums.PickType PickTypeId { get; set; }
    }
}
