using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class UserGroup:IdentityRole
    {
        public string NameRu { get; set; }
    }
}
