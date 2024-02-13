using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface ICard
    {
        int Id { get; set; }

        Enums.CardType CardTypeId { get; set; }

        int ExpansionId { get; set; }

        string Text { get; set; }

        Enums.PickType PickTypeId { get; set; }
    }
}
