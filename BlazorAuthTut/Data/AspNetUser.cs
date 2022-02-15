using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTut.Data
{
    public class AspNetUser : IdentityUser
    {
        public string School { get; set; }

    }
}
