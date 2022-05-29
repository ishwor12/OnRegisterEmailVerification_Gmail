using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class ApplicationUser : IdentityUser
    {
       

        internal static void Add(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }
    }
}
