using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
