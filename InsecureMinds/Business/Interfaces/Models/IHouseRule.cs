﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Models
{
    public interface IHouseRule
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        bool IsEnabled { get; set; }
    }
}
