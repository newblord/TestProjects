using Business.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsecureMindsMVC.Models
{
    public class ViewCardsModel
    {
        public IExpansion Expansion { get; set; }

        public IEnumerable<ICard> Cards {get;set;}
    }
}