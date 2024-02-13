﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Repositories
{
    public interface IRoomRepository
    {
        Models.IRoom CreateRoom();

        Models.IRoom GetRoom(int id);
    }
}
