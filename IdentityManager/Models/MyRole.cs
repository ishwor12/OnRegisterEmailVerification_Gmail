using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class MyRole : IdentityRole<string>
    {
        public MyRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public MyRole(string roleName) : this()
        {
            this.Name = roleName;
        }
    }
}
