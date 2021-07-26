﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface IUserGroup
    {
        Task<List<UserGroup>> GetUserGroups();
    }
}
