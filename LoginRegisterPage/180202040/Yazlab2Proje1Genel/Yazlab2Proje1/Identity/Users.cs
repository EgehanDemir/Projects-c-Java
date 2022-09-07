using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Yazlab2Proje1.Identity
{
    public class Users:IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}