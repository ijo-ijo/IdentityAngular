using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAngular.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string UserAvatar { get; set; }

        [PersonalData]
        public string Nickname { get; set; }
    }
}
